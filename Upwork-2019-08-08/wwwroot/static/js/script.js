$(document).ready(function(){
    $("#loading").hide()

    $(document).click(function(event){
        if(event.target === document.querySelector(".mycard") || event.target.parentElement === document.querySelector(".mycard") || event.target === document.querySelector(".ProfileMenu") || event.target.parentElement === document.querySelector(".ProfileMenu ul")){
            $(".ProfileMenu").addClass("DisplayOn")
        }else{
            $(".ProfileMenu").removeClass("DisplayOn")
        }

    })
})