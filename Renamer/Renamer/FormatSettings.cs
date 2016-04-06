using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer
{
    internal class FormatSettings
    {
        //---FIELDS---
            //***Spacing Style***                    ***Caps Style***
        private bool _isNormal_ = false;        private bool _isUpper_ = false;
        private bool _isUnderScore_ = false;    private bool _isLower_ = false;
        private bool _isNoSpacing_ = false;     private bool _isCammel_ = false;
                                            //private bool _isTitled_ = false;//first letter of 3 or less letter words are uppercased
                                            //private bool _isAllWordsTitled_ = false;//first letter of each word is capitalized
            //***Objects***
        public static FormatSettings fileSettings = new FormatSettings();
        public static FormatSettings folderSettings = new FormatSettings();
        public static FormatSettings refShownSettings = new FormatSettings();

        //---CONSTRUCTORS---
         public FormatSettings()
        {
            //do not delete, class requires 1 argumentless constructor
        }

        //---METHODS---
            //***Spacing Styles 'get' Methods***
         public bool isNormal       { get { return this._isNormal_; }      set { _isNormal_ = value; }     }
         public bool isUnderScore   { get { return this._isUnderScore_; }  set { _isUnderScore_ = value; } }
         public bool isNoSpacing    { get { return this._isNoSpacing_; }   set { _isNoSpacing_ = value; }  }
            //***Caps Styles 'get' Methods***
         public bool isUpper        { get { return this._isUpper_; }       set { _isUpper_ = value; }      }
         public bool isLower        { get { return this._isLower_; }       set { _isLower_ = value; }      }
         public bool isCammel       { get { return this._isCammel_; }      set { _isCammel_ = value; }     }

            //***All Other Methods***
        public static void showSettings(RadioButton radioButton ,FormatSettings format)
        {
                //'this' refers to object that method was invoked from
                //, not the argument

                //***Spacing Style***
                radioButton.Checked = format._isNormal_;
                radioButton.Checked = format._isUnderScore_;
                radioButton.Checked = format._isNoSpacing_;

                //***Caps Style***
                radioButton.Checked = format._isUpper_;//change to first letter caps
                radioButton.Checked = format._isLower_;
                radioButton.Checked = format._isCammel_;

                //***Visual Changes***

                //
                //
                //
                //
        }
    }
}
