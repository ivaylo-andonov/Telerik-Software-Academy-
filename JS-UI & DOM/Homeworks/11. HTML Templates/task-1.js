/* globals $ */

function solve() {
  
  return function (selector) {
    var template = '<table class="items-table"><thead><tr><th>#</th>' + 
					'{{#headers}}' +
					'<th>{{this}}</th>' +
					'{{/headers}}' +
					'</tr></thead><tbody>' +
					'{{#items}}'+
					'<tr><td>{{@index}}</td>' +
					'<td>{{this.col1}}</td>' +
					'<td>{{this.col2}}</td>' +
					'<td>{{this.col3}}</td>' +
					'</tr>' +
					'{{/items}}' +
					'</tbody></table>';
    $(selector).html(template);
  };
}

