function solve(params) {

    var input = params.join('');

    //first remove the white spaces
    input = input.replace(/\s*([^]+?)\s*{\s*([^]+?)\s*}/g, function (match, selectors, content) {
        content = content.replace(/\s*/g, '');
        content = content.replace(/;$/g, '');
    });

        selectors = selectors.replace(/\s+/g, ' ');
        selectors = selectors.replace(/^\s*/g, '');
        selectors = selectors.replace(/\s*$/g, '');
 

    return input;
}

function task() {
    console.log(solve(test));
}


var test = [

'#the-big-b{',
    'color: yellow;',
    'size: big;',
    '}',
'.muppet{',
        'powers: all;',
        'skin: fluffy;',
'}',
    '.water-spirit {',
        'powers: water;',
       'alignment : not-good;',
    '}',
    'all{',
        'meant-for: nerdy-children;',
    '}',
'.muppet {',
'powers: everything;',
'}',
'аll .muppet {',
   ' alignment : good ;',
'}',
'.muppet+ .water-spirit{',
    'power: everything-a-muppet-can-do-and-water;',
'}',

];