function createCalendar(selector, data){
	var container = document.querySelector(selector);
	var docFrag = document.createDocumentFragment();
	var selectedBox = null;
	
	var dayBox = document.createElement('div');
	var dayBoxHeader = document.createElement('strong');
	var dayBoxContent = document.createElement('div');
	dayBoxContent.innerHTML = '&nbsp';
	
	dayBox.appendChild(dayBoxHeader);
	dayBox.appendChild(dayBoxContent);
	
	// Add styles 
	
	dayBox.style.width = '120px';
	dayBox.style.height = '110px';
	dayBox.style.display = 'inline-block';
	dayBox.style.border = '1px solid purple';	
		
	dayBoxHeader.style.color = 'pink';
	dayBoxHeader.style.backgroundColor = 'green';	
	dayBoxHeader.style.display = 'inline-block';
	dayBoxHeader.style.width = '100%';
	container.style.width = '880px';
	dayBoxHeader.style.borderBottom = '1px solid purple';
	dayBoxHeader.style.textAlign = 'center';
	
	// Functions
	function createDayBoxes(){
		var dayBoxes = [];	
		for(var i = 0; i < 30; i+=1){
			var day = new Date(2014,05,i+1);
			dayBoxHeader.innerHTML = (day.toDateString());
			dayBoxes.push(dayBox.cloneNode(true));
		}		
		return dayBoxes;
	}
	
	function addEvents(boxes, events){
		for(var i = 0; i < events.length; i+=1){
			var event = events[i];
			var contentBox = boxes[(event.date) - 1].lastElementChild;
			contentBox.innerHTML = event.hour + ', ' + event.title;
		}
	}
	
	function onBoxClick(ev){
		
		if(selectedBox){
			selectedBox.style.backgroundColor = '';
		}
		this.style.backgroundColor = 'lime';
		selectedBox = this;
	}
	
	function onBoxMouseover(ev){
		if(selectedBox !== this){
			this.style.backgroundColor = 'yellow';
		}		
	}
	
	function onBoxMouseout(ev){
		if(selectedBox !== this){
			this.style.backgroundColor = '';
		}
	}
	
	var boxes = createDayBoxes();
	addEvents(boxes,events);
	
	// Add eventListeners after cloning, because clone doesn`t clone the events!
	for(var i = 0,len = boxes.length; i< len; i+=1){
		var currBox = boxes[i];
		docFrag.appendChild(currBox);
		currBox.addEventListener('mouseout', onBoxMouseout);
		currBox.addEventListener('mouseover', onBoxMouseover);
		currBox.addEventListener('click', onBoxClick);
	}
	
	container.appendChild(docFrag);
}