$.fn.tabs = function () {
	var $this = $(this);
	$this.addClass('tabs-container');
	$this.find('.tab-item-content').hide();
	
	$this.on('click','.tab-item-title',function(ev){
		var $clickedTitle = $(this);		
	    $this.find('.tab-item-content').hide();
		$clickedTitle.next().show();
		$this.children().removeClass('current');
		$clickedTitle.parent().addClass('current');
	})
};












