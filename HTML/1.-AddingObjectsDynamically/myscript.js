var counter = 0;

var flag = false;
document.addEventListener('DOMContentLoaded', function(){
	console.log("This method will be executed once the browser render all the objects ");
	console.log("Hello world :D");
})

function buttonClicked(){

/*
This is a block of comments

*/
//	console.log("The button has been clicked");
	
	counter = counter + 1;
	console.log("The value of counter is " + counter);
	
	var myContainer = document.getElementById('mycontainer')
	if(flag == false){
		var dynamicParagraph = "<p class='class1'> Element "+counter+ " added dynamically</p>";
		flag = true;
	}
	else{
		var dynamicParagraph = "<p class='class2'> Element "+counter+ " added dynamically</p>";
		flag = false;
	}
	myContainer.insertAdjacentHTML('beforeend', dynamicParagraph)
}


function makeValidation(){
	console.log("This function was executed because we want to send the form");
	return false;
}