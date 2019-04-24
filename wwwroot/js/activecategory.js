$("a.list-group-item").click(function(e){
    // console.log($(this).attr('id'))
          $("div.card.mb-3").css("display","none")
          var categoryid=$(this).attr('id')
          if(categoryid!=0)
               $( "#myID\\.entry\\["+categoryid+"\\]" ).css("display","block")
          else
              $("div.card.mb-3").css("display","block")
})