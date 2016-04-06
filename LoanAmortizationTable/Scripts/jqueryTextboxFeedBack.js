function setTextBoxFeedBack(divID, inputID, spanGlyphID, spanValidatorID) {
    var d = $(divID);
    var i = $(inputID);
    var sg = $(spanGlyphID);
    var sv = $(spanValidatorID);
    i.change(
          function () {
              if (i.val() != "") {
                  if (sv.css("display") != "none")//span validator icon id
                  {
                      d.removeClass("has-success");//div parent id
                      sg.removeClass("glyphicon-ok");// span glyph icon id
                      d.addClass("has-error");//div parent id
                      sg.addClass("glyphicon-remove");//span glyph icon id
                  }
                  else {
                      d.removeClass("has-error");//div parent id
                      sg.removeClass("glyphicon-remove");//span glyph icon id
                      d.addClass("has-success");//div parent id
                      sg.addClass("glyphicon-ok");//span glyph icon id
                  }
              }
              else {
                  d.removeClass("has-success");//div parent id
                  sg.removeClass("glyphicon-ok");// span glyph icon
                  d.removeClass("has-error");// div parent id
                  sg.removeClass("glyphicon-remove");//span glyph icon
              }
          }
          );//END: event
}
