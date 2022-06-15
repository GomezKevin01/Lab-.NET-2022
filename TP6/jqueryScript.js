$(document).submit(function() { 
	if($("#nombre").val().length < 1) {  
        	alert("El nombre es obligatorio");
        }
        if($("#apellido").val().length < 1) {  
        	alert("El apellido es obligatorio");
        }
        if($("#edad").val().length < 1) {  
        	alert("La edad es obligatoria");
        }
        if($("#edad").val().length < 1  || $("#apellido").val().length < 1 || $("#nombre").val().length < 1 ){ 
                   return false; 
                }
});


