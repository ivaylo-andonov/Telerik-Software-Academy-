function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);
	var dFrag = document.createDocumentFragment();
	
	var leftSide = document.createElement('div');
	var leftSideTitle = document.createElement('h2');
	leftSideTitle.innerText = items[0].title;
	var leftSideImg = document.createElement('img');
	leftSideImg.src = items[0].url;
	var rightSide = document.createElement('div');
	rightSide.classList.add('image-preview');
	var rightSideTitle = document.createElement('h4');
	rightSideTitle.innerText = 'Filter';
	var rightSideInput = document.createElement('input');
	var rightSideBoxes = document.createElement('div');
	
	// Styles
	container.style.textAlign = 'center';
	container.style.heigth = '500px';
	leftSide.style.float = 'left';
	rightSide.style.float = 'left';
	rightSide.style.marginLeft = '25px';
	rightSideBoxes.style.height = '360px';
	rightSideBoxes.style.overflowY = 'scroll';
	rightSideBoxes.style.border = '1px solid black';
	leftSideImg.style.width = '500px';
	leftSideImg.style.borderRadius = '15px';
	rightSideInput.style.marginBottom = '10px';
	
	var newDiv = document.createElement('div');
	
	for(var i = 0, len = items.length; i < len; i +=1){
		var currItem = items[i];
		var cloneDiv = newDiv.cloneNode(true);
		var picTitle = document.createElement('h5');
		picTitle.innerText = currItem.title;
		var pic = document.createElement('img');
		pic.src = currItem.url;
		pic.style.width = '140px';
		pic.style.borderRadius = '15px';
		cloneDiv.appendChild(picTitle);
		cloneDiv.appendChild(pic);
		dFrag.appendChild(cloneDiv);
	}
	
	//Events	
	rightSideBoxes.addEventListener('click', function(ev){
		var target = ev.target;
		if(target.nodeName == 'IMG'){
			leftSideImg.src = target.src;
			leftSideTitle.innerText = target.previousElementSibling.innerText;
		}	
	},false)
		
	rightSideBoxes.addEventListener('mouseover', function(ev){
		var target = ev.target;
		if(target.nodeName == 'IMG'){
			target.parentNode.style.backgroundColor = 'grey';
			target.style.cursor = 'pointer';
		}
	},false)
	
	rightSideBoxes.addEventListener('mouseout', function(ev){
		var target = ev.target;
		if(target.nodeName == 'IMG'){
			target.parentNode.style.backgroundColor = '';
		}
	})
	
	//Filter	
	rightSideInput.addEventListener('keyup', function(ev){
		var inputValue = ev.target.value;
		var boxItems = rightSideBoxes.childNodes;
		for(var i = 0, len = boxItems.length; i< len; i+=1){
			var currBox = boxItems[i];
			var header = currBox.firstElementChild.innerText;
			if(header.toLowerCase().indexOf(inputValue.toLowerCase()) >= 0 ){
				currBox.style.display = 'block';
			}
			else{
				currBox.style.display = 'none'
			}
		}		
	},false)
	
	rightSideBoxes.appendChild(dFrag);
	leftSide.appendChild(leftSideTitle);
	leftSide.appendChild(leftSideImg);
	rightSide.appendChild(rightSideTitle);
	rightSide.appendChild(rightSideInput);
	rightSide.appendChild(rightSideBoxes);
		
	container.appendChild(leftSide);
	container.appendChild(rightSide);	
}