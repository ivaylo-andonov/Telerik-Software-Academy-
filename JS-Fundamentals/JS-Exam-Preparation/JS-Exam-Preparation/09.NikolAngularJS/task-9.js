function solve(view) {

    // PARSE MODELS
    var modelsCount = view[0] | 0;
    var models = {};
    for (var i = 1; i <= modelsCount; i += 1) {
        var currentLine = view[i];
        var modelName = currentLine.split(':')[0];
        var modelValue = currentLine.split(':')[1].split(',');
        models[modelName] = modelValue;
    }
    view = view.slice(modelsCount + 2).join('\n');
    // console.log(view);



    // PARSE SECTIONS
    var sections = {};
    view = view.replace(/@section (.+?) {\n([^]+?)\n}\n/g
		, function (match, secName, secContent) {
		    sections[secName] = secContent;
		    return '';
		});



    // MARK ESCAPES
    view = view.replace(/@@/g, '@@$');



    // PROCESS MODELS
    view = view.replace(/@(\w+)/g
		, function (match, modelName) {
		    if (models[modelName] !== undefined) {
		        return models[modelName].join(',');
		    } else {
		        return match;
		    }
		});
    // console.log(view);



    // RENDER SECTIONS
    view = view.replace(/( *?)@renderSection\("(.+?)"\)/g,
		function (match, tabbing, secName) {
		    return sections[secName].replace(/^/gm, tabbing);
		});


    // PROCESS CONDITIONALS
    view = view.replace(/( *?)@if \((.+?)\) {\n([^]+?)}\n/g,
		function (match, tabbing, conditionName, conditionContent) {
		    if (models[conditionName][0] === 'true') {
		        return conditionContent.replace(/^ {4}/gm, '');
		    } else {
		        return '';
		    }
		});


    // PROCESS LOOPS
    view = view.replace(/ *@foreach \(var (.+?) in (.+?)\) \{\n([^]+?)\}\n/g,
		function (match, placeholder, modelName, content) {
		    var finalContent = '';
		    content = content.replace(/\s*$/, '\n');
		    for (var i = 0; i < models[modelName].length; i += 1) {
		        finalContent += content.
					replace(new RegExp('@' + placeholder, 'g'), models[modelName][i])
					.replace(/^ {4}/gm, '');
		    }
		    return finalContent;
		    // return '';
		});


    // UNMARK AND REMOVE ESCAPES
    view = view.replace(/@@\$/g, '@').replace(/@@/g, '@');

    console.log(view);
}

function task() {
    var test0 = ['6', 'title:Telerik Academy', 'showSubtitle:true', 'subTitle:Free training', 'showMarks:false', 'marks:3,4,5,6', 'students:Pesho,Gosho,Ivan', '42', '@section menu {', '<ul id="menu">', '    <li>Home</li>', '    <li>About us</li>', '</ul>', '}', '@section footer {', '<footer>', '    Copyright Telerik Academy 2014', '</footer>', '}', '<!DOCTYPE html>', '<html>', '<head>', '    <title>Telerik Academy</title>', '</head>', '<body>', '    @renderSection("menu")', '', '    <h1>@title</h1>', '    @if (showSubtitle) {', '        <h2>@subTitle</h2>', '        <div>@@JustNormalTextWithDoubleKliomba ;)</div>', '    }', '', '    <ul>', '        @foreach (var student in students) {', '            <li>', '                @student ', '            </li>', '            <li>Multiline @title</li>', '        }', '    </ul>', '    @if (showMarks) {', '        <div>', '            @marks ', '        </div>', '    }', '', '    @renderSection("footer")', '</body>', '</html>'];

    solve(test0);
}
