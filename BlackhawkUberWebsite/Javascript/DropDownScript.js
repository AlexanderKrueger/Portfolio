//Load after JQuery plug-in

$(document)
.ready
(
  function()
  {
    //--- VARIABLES ---
    //*** XML Strings ***
    svgArrowShow = '<svg class="drop-down-arrow"><polygon points="10,15 18,8 2,8" fill="#9BE"/>Sorry, your browser does not support inline SVG.</svg>';
    svgArrowHide = '<svg class="drop-down-arrow drop-down-arrow-hide"><polygon points="10,15 18,8 2,8" fill="#9BE"/>Sorry, your browser does not support inline SVG.</svg>';
    
    //*** Flags ***
    flagA = true;
    
    //--- CLASS GENERATION ---
    //*** Drop Down Content ***
    $(".drop-down-content")
    .addClass("drop-down-content-hide");
    
    //*** Drop Down Arrow ***
    $(".drop-down-button")
    .append(svgArrowShow);
    
    //--- EVENT ACTIONS ---
    //*** Drop Down Button Event ***
   $(".drop-down-button")
   .click(
     function()
    {
      if(flagA == true) 
        { flagA = !flagA; $(this).html( svgArrowHide ); }
      else 
        { 
        flagA = !flagA; $(this).html( svgArrowShow ); 
        
        }
      $(this)
      .toggleClass("drop-down-open")
      .next()// element: drop down header
      .next()// element: drop down content
      .slideToggle("slow")//remove or comment out line if jquery ui isn't loaded
      .toggleClass("drop-down-content-show drop-down-content-hide");
    }
   );
  }
)