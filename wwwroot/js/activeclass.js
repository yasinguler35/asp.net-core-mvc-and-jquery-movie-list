    //menu aktif class değiştirme
    //menu active class change
    $(document).ready(function(){
  
        $("a.list-group-item").click(function(e){
            $("a.list-group-item").removeClass("active")
            $(this).addClass("active")
            e.preventDefault()
        })
    })