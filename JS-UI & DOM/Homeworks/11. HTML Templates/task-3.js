function solve(){
  return function(){
    $.fn.listview = function(data){
      var $this = $(this),
          template = $("#" + $this.attr('data-template')).html();

      var compiledTemplate = handlebars.compile(template);

      for (var i = 0; i < data.length; i++) {
        $this.append(compiledTemplate(data[i]));
      }
	  
	  return this;
    };
  };
}