$(document).ready(function() {
	$("#search_form").submit(function(e) {
		//e.preventDefault();
		
		//var txtPropertySearchListing = $("#txtPropertySearchListing").val();
		// $("#btnSearch").click(function() {
			
			// var txtPropertySearch = $('#txtPropertySearch').val();
			// var selPropertyType = $('#selPropertyType').val();
			
			// searchProperty(txtPropertySearch, selPropertyType);
			
		// });	
	});
});

function searchProperty(txtPropertySearch, selPropertyType) {			
	$.ajax({
	  type: "POST",
	  url: "property_listing.html",
	  data: selPropertyType,
	  success: function(){
		  alert('test');
	  }	  
	});
}

