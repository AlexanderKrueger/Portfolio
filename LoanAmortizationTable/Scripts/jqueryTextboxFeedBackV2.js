//---TextBoxFeedBack.js---
//NOTE: Will require that ids are inputed in an order diffrent from the current.
//---SCRIPT VARIABLES---
var ControlArray = new Array();//<-- (objects) Controls

//Below function Adds a 'TextBoxFeedBack' control to 'ControlArray'.
//Each argument of the below function should be a CSS id selector stored as a string value (i.e. arg1 might equal "#ThisIsASelector").
function addTextBoxFeedBack(
argIdSelector1_DivParent,
argIdSelector2_TextBoxID,
argIdSelector3_Validator,//TODO: Modify argument to take a ASP 'ValidatorGroup' tag instead of the ID for 1 validator.
argIdSelector4_GlyphIcon)
{
//Create 'Control' object for each 'TextboxFeedBack' control via args.
var Control = new Object();
Control.ParentTextBoxID = $(argIdSelector1);
Control.TextBoxID = $(argIdSelector2);
Control.ValidatorID = $(argIdSelector3);
Control.GlyphIconID = $(argIdSelector4);
//Add object to the 'ControlArray'.
ControlArray.push(Control);//Appends object to 'Control Array'.
}

//Don't use the below function more than once on a web page. It's completely unnecessary.
function showFeedBack()
{
    $(document).ready(
    function()
    {
        //Gives visual feedback for each control in the array.
        foreach(control in ControlArray)
        {
            //Textboxes with visual feedback are updated 
            //every time that both:
            //1) The input changed. 
            //2) The user clicked on a diffrent control in the webpage.
            control.TextBoxID.change(
              function () 
              {
                  if (control.TextBoxID.val() != "") 
                  {
                      // css("display") != "none" is the condition used since "none" is the only value when the textbox input is invalid.
                      if (control.ValidatorID.css("display") != "none")
                      {
                          //Sets visual feedback: show input is invalid.
                          control.ParentTextBoxID.removeClass("has-success");
                          control.GlyphIconID.removeClass("glyphicon-ok");
                          control.ParentTextBoxID.addClass("has-error");
                          control.GlyphIconID.addClass("glyphicon-remove");
                      }
                      else
                      {
                          //Sets visual feedback: show input is valid.
                          control.ParentTextBoxID.removeClass("has-error");
                          control.GlyphIconID.removeClass("glyphicon-remove");
                          control.ParentTextBoxID.addClass("has-success");
                          control.GlyphIconID.addClass("glyphicon-ok");
                      }
                  }
                  else 
                  {
                      //Removes visual feedback if textbox is unfilled.
                      control.ParentTextBoxID.removeClass("has-success");
                      control.GlyphIconID.removeClass("glyphicon-ok");
                      control.ParentTextBoxID.removeClass("has-error");
                      control.GlyphIconID.removeClass("glyphicon-remove");
                  }
              }/*END OF: 'if' and 'else' statments nested in function*/);//END OF: 'change' event
        }//END OF: foreach loop
    });//END OF: JQuery's 'ready' event
}//END OF: feedback code

