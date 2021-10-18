var counter = 0;

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

	var dynamicParagraph = "<p> Element "+counter+ " added dynamically</p>";
	myContainer.insertAdjacentHTML('beforeend', dynamicParagraph)
}


function makeValidation(){
	console.log("This function was executed because we want to send the form");
	return false;
}