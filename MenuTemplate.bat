::
::CODEING FORMAT RULES
::

::1) 1 empty line before, 2 empty lines after each 'header'
::(example: Header)----------------------------------------------------------
::                  |                         ::<--empty line 1
:: document edge -->|                         ::<--empty line 2
::                  |::
::                  |::This is a Header
::                  |::
::                  |                         ::<--empty line after
::---------------------------------------------------------------------------
::note: headers separate code into navigatable parts
::
::2) Camall Case applies to variable names
::
::examples:
::  thisIsAVariableName
::  mayTheForceBeWithYou
::  aVariable
::  variablesAreUs
::
::3) Reserved words are typed in all capitals
::
::examples:
::  HELP
::  RECOVER
::  SORT
::  SET
::
::4) No period at the end of a comment or a series of comments
::
::examples:
::	correct:  ::this sentence is in a comment. this is an ending comment
::  correct:  ::this single comment is correct
::  incorrect:  ::this sentence is in a comment. this is not an ending comment.
::  incorrect:  ::this single comment is incorrect.
::
::5) reserved word switches must be capitalized
::
::examples:
::  correct:  SET /P prompt="prompt message"
::  correct:  SET /A number=42
::  incorrect:   SET /p prompt="prompt message"
::  incorrect:   SET /a number=42
::
::6) anything unrestricted is permitted


::
::MAIN CODE
::

ECHO off
CLS
TITLE Menu Template

::V4 each menu gets the following:
::1) border variables (firstOption, LastOption) - prevent pointer from going
::off the menu
::
::2) option variables(when pointer is used) - labels for each option that are 
::shown on the menu
::
::3) option variables(when pointer is not used) - labels for each option that
::are shown on the menu
::
::4) a 'driver' routine - to drive the execution of code for the menu
::
::---inside the driver---
::1) function to render the menu options
::
::2) function to prompt the user to make a choice via pointer or number
::(depending on interface mode thats used)
::
::3) GOTO statement to send control of code execution back to the top of
:: the driver

::***debugging variables***
:: (below) 'debug Mode' ,when set to 'on', partitions
:: the code into sections via 'PAUSE' and 'ECHO' (to
:: 'echo' a 'checkpoint number') so the
:: current programmer can narrow the location of
:: most bugs(exception being logical or resource
:: managment related bugs that don't trigger error/s
:: immedietly)
::
:: to turn 'debugMode' on, assign the string value
:: 'on' (with out single quotes) to the variable
:: 'debugMode'
::
:: when turning 'debugMode' off, please assign the
:: string value 'off' (without single quotes) 
:: to the variable 'debugMode' as with every available
:: 'on' setting, there is it's commen sense counter
:: part called 'off'
SET debugMode=off

::***set defualt option variables***
   SET topDecrative=---- defualt top decrative     ----
      SET menuTitle=---- defualt menu title        ---- 
SET bottomDecrative=---- defualt bottem decrative  ----
REM (below) message must be contained in double qoutes
SET pointerChoiceMessage="u - up/ d - down/ s - select/ t - toggle pointer"
SET pointerChoices=udst
REM (below) message must be contained in double qoutes
SET selectByCharChoiceMessage=select option by number
REM (below) function call is required to intialize default variables
CALL :revertToDefaultOptions

::***border variables***
SET /A firstOption = 1
SET /A lastOption = 7
PAUSE
::(below) initial location of pointer is set
SET /A selected = %firstOption%
::note1: (above)SET /A is required for anything (setting and assigning) of
::numbers
::
::note2: (above)have no spaces next to equals sign when assigning strings to
::variables
::
::note3: (above)comments can't be placed after "SET /A"; otherwise,
::"missing operator" appears
::
::In V2 the 'option variables' were located below. Currently these variables
::are in what is now the runMainMenu(as of update V3) function

::***toggle Value***
::value that determines the interface all menus use.
::interfaces: pointer/ no pointer
SET isPointerUsed=yes
                                  
::option variables that are not used don't impact the options displayed on each
::menu. only the 'option variables' declarations(value assignment) in each menus
::code is designed to be shown
::
::Note: the only practical reason that variables are being declared here is to
::help th developer understand the frame work of this code

::***pointer variables***
::pointer refers to the pointer visible on screen.
::
:: caution: don't use '(' or ')' as part of the
:: pointer as doing so will cause glicthes or errors
::
::(below) every visual option for the pointer is declared
SET pointer1={+}
SET pointer2={-}
SET pointer3={0}
SET pointer4=[-]
SET pointer5=[:]
SET pointer6=[0]
SET pointer7=-$-
SET pointerInUse=%pointer1%
                               
::(below)starts up the first menu that leads to all other menus
GOTO runMainMenu


::
::FUNCTIONS
::

::---FUNCTION---
:runMainMenu
::(above)function label should fit into this format: runMenu (menu name here)
:: i.e. runMenuPointer, runMenuSettings, runMenuGuest

::note: function is a 'menu runner'

::***menu title and decratives***
::(below) these three 'SET' statments are aligned in this way so it is easy
::to visualize how the menu title and decratives will look on the menu 
   SET topDecrative=--------------------
      SET menuTitle=*    Main Menu     * 
SET bottomDecrative=-------------------- 

::***recycle option variables***
CALL :revertToDefaultOptions
                                         
::***border variables***
SET /A firstOption = 1
SET /A lastOption = 7

::***line breaks in option list***
::use only the string values "yes" and "no" for the line break variables

::(below) variable determins if the 'no-pointer' enviorment uses a diffrent
:: placement of line breaks than the 'pointer' enviorment

::(below)syncronize break lines for both the pointer 'on' and 'off' menu modes? 
SET syncedBreakPlacement=yes

::LineBreakPlacing1 (for when pointer is 'on', though, can be synced for 'off')
::(a.k.a. lineBreakP1 variables)
SET op1LineBreak_P1=no
SET op2LineBreak_P1=no
SET op3LineBreak_P1=no
SET op4LineBreak_P1=yes
SET op5LineBreak_P1=no
SET op6LineBreak_P1=no
SET op7LineBreak_P1=no

::LineBreakPlacing2 (for when pointer is off)
::(a.k.a. lineBreakP2 variables) 
IF "%syncedBreakPlacement%" == "no" (
SET op1LineBreak_P2=no
SET op2LineBreak_P2=no
SET op3LineBreak_P2=no
SET op4LineBreak_P2=no
SET op5LineBreak_P2=no
SET op6LineBreak_P2=no
SET op7LineBreak_P2=no
)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 1
::***option variables***
::(below)option labels when the pointer is used
::Var Name | Option Label
IF "%isPointerUsed%" == "yes" (
SET option1=option 1 example multi-program launch
SET option2=option 2
SET option3=option 3
SET option4=option 4
SET option5=Toggle Pointer
SET option6=Change Pointer
SET option7=Exit Menu
)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 2                                    
::(below)option labels when the pointer isn't used.
::Var Name | Option Label                                                                                
IF "%isPointerUsed%" == "no" (
SET option1= 1 - option 1 example multi-program launch
SET option2= 2 - option 2
SET option3= 3 - option 3
SET option4= 4 - option 4
SET option5= 5 - Toggle Pointer
SET option6= 6 - Change Pointer
SET option7= 7 - Exit Menu
)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 3
::***Driver***
CALL :placePointer

::return from placePointer
CALL :mainMenuPromptOptions
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 4
::return from mainMenuPromptOptions
GOTO runMainMenu
::END/runMainMenu
                    
::---FUNCTION---
:runPointerMenu
::note: function is a 'menu runner'

::***menu title and decratives***
::(below) these three 'SET' statments are aligned in this way so it is easy
::to visualize how the menu title and decratives will look on the menu 
   SET topDecrative=---------------------
      SET menuTitle=*   Pointer Menu    * 
SET bottomDecrative=---------------------

::***recycle option variables***
REM (below) should start at the begining of every menu's code
CALL :revertToDefaultOptions

::***border variables***
SET /A firstOption = 1
SET /A lastOption  = 7

::***line breaks in option list***
::use only the string values "yes" and "no" for the line break variables

::(below) variable determins if the 'no-pointer' enviorment uses a diffrent
:: placement of line breaks than the 'pointer' enviorment

::(below)syncronize break lines for both the pointer 'on' and 'off' menu modes? 
SET syncedBreakPlacement=yes

::LineBreakPlacing1 (for when pointer is 'on', though, can be synced for 'off')
::(a.k.a. lineBreakP1 variables)
SET op1LineBreak_P1=no
SET op2LineBreak_P1=no
SET op3LineBreak_P1=no
SET op4LineBreak_P1=no
SET op5LineBreak_P1=no
SET op6LineBreak_P1=no
SET op7LineBreak_P1=no

::LineBreakPlacing2 (for when pointer is off)
::(a.k.a. lineBreakP2 variables) 
IF "%syncedBreakPlacement%" == "no" (
SET op1LineBreak_P2=no
SET op2LineBreak_P2=no
SET op3LineBreak_P2=no
SET op4LineBreak_P2=no
SET op5LineBreak_P2=no
SET op6LineBreak_P2=no
SET op7LineBreak_P2=no
)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 5
::***option variables***
::option labels when the pointer is used
::Var Name | Option Label
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 6
IF "%isPointerUsed%" == "yes" (
SET option1=  %pointer1%
SET option2=  %pointer2%
SET option3=  %pointer3%
SET option4=  %pointer4%   
SET option5=  %pointer5%   
SET option6=  %pointer6%   
SET option7=  %pointer7%   
)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 7
::option labels when the pointer isn't used.
::Var Name | Option Label
IF "%isPointerUsed%" == "no" (
SET option1= 1 - %pointer1%
SET option2= 2 - %pointer2%
SET option3= 3 - %pointer3%
SET option4= 4 - %pointer4%
SET option5= 5 - %pointer5%
SET option6= 6 - %pointer6%
SET option7= 7 - %pointer7%
)

::***Driver***
::(below) place pointer is reused here since it's 'universal'
CALL :placePointer
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 8
::return from placePointer
CALL :pointerMenuPromptOptions

::return from pointerMenuPromptOptions
GOTO runPointerMenu
::END/runPointerMenu

::---FUNCTION---
::name it 'plop down menu'?
::name it 'placePointerAndPrintMenu'?
::name it 'printMenuAndPlacePointer'?
::name it 'updatePointer'?
::name it 'updatePointerLocation'?
::name it 'refreshMenu'? - for it 'refreshes' a menu
::should it be by numeric selcetion or pointer
::selection
:placePointer
::(below code) an universal function that updates the location of the pointer.
::can be used by multiple menus as long as the number of options 
::(in this code below) can accomodate the number of options in those menus.
::
::at the moment, the place pointer function is used in every menu's 'driver'.
::
::don't worry about the pointer falling off the menu. So long as you set the
::right value for 'firstOption' and 'lastOption' in each menu (border variables)
::, you'll be fine
::
::the idea of calling this code from multiple menus may seem like a dumb idea to
::some. for those who do oppose the idea, keep in mind this code could be
::helpful if your working with vast amounts (i.e. 6 linked menus) of connected
::menus when your trying to remain organized.
::
::finally, please note the 'CLS' command right after this series of comments.
::it clears the state or 'frame' of a menu so the next state or 'frame' of the
::menu can be shown. this gives the user the illusion that there is a movable
::pointer on a menu. so please avoid deleting that 'CLS' command
CLS

IF "%debugMode%" == "on" (
ECHO -Display:with pointer-
ECHO selected = %selected%
ECHO is Pointer Used: %isPointerUsed%
ECHO pointer in use: %pointerInUse%
)

ECHO %topDecrative%
ECHO %menuTitle%
ECHO %bottomDecrative%                                        
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 9
 REM function 'examSelectable' determins if the pointer should be placed
 CALL :examSelectable "1" "%option1%"
 CALL :placeLineBreak "%syncedBreakPlacement%" "%op1LineBreak_P1%" "%op1LineBreak_P2%"
  
 CALL :examSelectable "2" "%option2%"
 CALL :placeLineBreak "%syncedBreakPlacement%" "%op2LineBreak_P1%" "%op2LineBreak_P2%"
  
 CALL :examSelectable "3" "%option3%"
 CALL :placeLineBreak "%syncedBreakPlacement%" "%op3LineBreak_P1%" "%op3LineBreak_P2%"
  
 CALL :examSelectable "4" "%option4%" 
 CALL :placeLineBreak "%syncedBreakPlacement%" "%op4LineBreak_P1%" "%op4LineBreak_P2%"
 
 CALL :examSelectable "5" "%option5%"
 CALL :placeLineBreak "%syncedBreakPlacement%" "%op5LineBreak_P1%" "%op5LineBreak_P2%"
  
 CALL :examSelectable "6" "%option6%"
 CALL :placeLineBreak "%syncedBreakPlacement%" "%op6LineBreak_P1%" "%op6LineBreak_P2%"
  
 CALL :examSelectable "7" "%option7%"
 CALL :placeLineBreak "%syncedBreakPlacement%" "%op7LineBreak_P1%" "%op7LineBreak_P2%" 
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 10
GOTO :EOF
::END/placePointer

::---FUNCTION---
:placeLineBreak
::arg 1: accepts variable 'syncedBreakPlacement' from a
::       menu runner (i.e. runMainMenu, runPointerMenu)
::arg 2: accepts "yes" of lineBreakP1 variables
::       (i.e. op1LineBreakP1, op2LineBreakP1) from a menu runner 
::arg 3: accepts "yes" or "no" variable value  of lineBreakP2 variables
::       (i.e. op1LineBreakP2, op2LineBreakP2) from a menu runner
::
::note1: please place "no" as the input
::      for readablility
::
::note2: when using this function, please surrond arguments
::       in double qoutes. Otherwise, the function will not
::       function properly

::(below) decrative is set
SET LineBreak=---------------------

::(below) for when the pointer is used. line echos the lineBreakP1 variable (%2)
:: if it has a "yes" value
 IF "%isPointerUsed%" == "yes" (                     
                            IF %2 == "yes" ECHO %LineBreak%
                            )
                             
::(below) for when the pointer isn't used. if 'syncedBreakPlacement'(%1) is on
:: and the previous lineBreakP1 variable (%2) was echoed, then the previous 
:: is echoed again
IF "%isPointerUsed%" == "no" (
                         IF %1 == "yes" (
                                       IF %2 == "yes" ECHO %LineBreak%
                                       )
                                        
                          REM (below) if 'syncedBreakPlacement'(%1) is off, then a lineBreakP2 variable(%3)
                          REM is checked in place of the lineBreakP1 variable (%2)
                         IF %1 == "no"  (
                                       IF %3 == "yes" ECHO %LineBreak%
                                       )
                           )


GOTO :EOF
::END/placeLineBreak

::---FUNCTION---
:mainMenuPromptOptions                                                                        
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 11
::there needs to be custom 'promptOptions'. the above function name falls into
::that category of function
::code blocks since no menus have the same options.

IF "%isPointerUsed%" == "yes" (
CHOICE /C %pointerChoices% /M %pointerChoiceMessage%)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 12                                       
REM IF statment is now done, and 'ERRORLEVEL' is
REM updated

IF "%isPointerUsed%" == "yes" (
REM works: IF %isPointerUsed% == yes
REM works: IF %isPointerUsed%==yes
REM works: IF %isPointerUsed%=="yes"
REM works: IF "%isPointerUsed%" == "yes"

REM don't change below if statements so the first if is  
REM "IF %ERRORLEVEL% == quoted number" as this will cause the first and second lines
REM of if's to execute when ERRORLEVEL = 2
REM                                                                                                 
REM (below) if statements in/decrement based on choice, or selection is chosen
IF %ERRORLEVEL% == 1 (IF %selected% GTR %firstOption% SET /A selected -= 1 & GOTO :EOF)
IF %ERRORLEVEL% == 2 (IF %selected% LSS %lastOption% SET /A selected += 1 & GOTO :EOF)
IF %ERRORLEVEL% == 3 GOTO mainMenuListOfOptionsAndActions
IF %ERRORLEVEL% == 4 CALL :togglePointer & GOTO runMainMenu

REM (below) if 'selected' = 'firstOption' or 'lastOption', then this function
REM is ended to prevent any action from occuring when nothing was truely
REM selected
GOTO :EOF
)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 13
IF "%isPointerUsed%" == "no" (
CHOICE /C 1234567 /M "%selectByCharChoiceMessage%"
)                         
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 14                               
IF "%isPointerUsed%" == "no" (
SET /A selected=%ERRORLEVEL%
)                                                                                        
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 15                                                                         
REM (below) extra 'PAUSE' is so and error created below the 'PAUSE' doesn't
REM prevent the above debugging line from echoing a 'checkpoint'
IF "%debugMode%" == "on" PAUSE

:mainMenuListOfOptionsAndActions
::(below) a list of options and their actions should one be selected
                     (
		      IF %selected% == 1 ECHO example option & "C:\Program Files (x86)\PSPad editor\PSPad.exe" & "C:\Program Files\AVAST Software\Avast\avastui.exe"
		      IF %selected% == 2 ECHO message2 & PAUSE
		      IF %selected% == 3 ECHO message3 & PAUSE
		      IF %selected% == 4 ECHO message4 & PAUSE                                        
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 16                                                       
		      IF %selected% == 5 CALL :togglePointer
			    REM (below) selected is reset(placed at first option) for the new menu
          IF %selected% == 6 CALL :returnPointerToStart & GOTO runPointerMenu                                                
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 17
          REM (above)changing menus simply requires the control to be given to a different
          REM menu using the GOTO reserved word
                            REM (above) second pause after puase created from above test
          If %selected% == 7 CALL :placePointer & GOTO END
		     )
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 18
         REM CALL :revertToDefaultOptions &     on the before of option 6   before runPointerMenu to serve as reset
         
GOTO :EOF
::END/mainMenuPromptOptions

::---FUNCTION---
::name it 'pointerMenuPromptChoices'?
:pointerMenuPromptOptions
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 19
IF "%isPointerUsed%" == "yes" (
CHOICE /C %pointerChoices% /M %pointerChoiceMessage%)

IF "%isPointerUsed%" == "yes" (
REM don't change below if statements so the first if is
REM "IF ERRORLEVEL == quoted number"
REM as this will cause the first and second lines of if's to execute when
REM ERRORLEVEL = 2                                                                                             
REM
REM the below if statements in/decrement based on choice, or selection is chosen
IF %ERRORLEVEL% == 1 (IF %selected% GTR %firstOption% SET /A selected -= 1)
IF %ERRORLEVEL% == 2 (IF %selected% LSS %lastOption% SET /A selected += 1)

IF %ERRORLEVEL% == 3 CAll :changePointer & CALL :returnPointerToStart & GOTO runMainMenu
IF %ERRORLEVEL% == 4 CALL :togglePointer & GOTO runPointerMenu
)                                                                       
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 20
IF "%isPointerUsed%" == "no" (
CHOICE /C 1234567 /M "%selectByCharChoiceMessage%"
)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 21
IF "%isPointerUsed%" == "no" (
SET /A selected = %ERRORLEVEL%)
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 22
IF "%isPointerUsed%" == "no" (                                                                                 
CALL :changePointer
GOTO runMainMenu)

REM (below) a reminder to create 
REM listOfOptionsAndActions labels so the coder
REM can go directly to and edit what selecting each
REM option will do
REM
REM the label, though, actualy leads to no actions
:pointerMenuListOfOptionsAndActions                                                           
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 23
		
GOTO :EOF
::END/pointerMenuPromptOptions

::---FUNCTION---
:changePointer                                                
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint checkpoint 24
::changes pointer based on 'selected'
IF %selected% == 1 SET pointerInUse=%pointer1%
IF %selected% == 2 SET pointerInUse=%pointer2%
IF %selected% == 3 SET pointerInUse=%pointer3%
IF %selected% == 4 SET pointerInUse=%pointer4%
IF %selected% == 5 SET pointerInUse=%pointer5%
IF %selected% == 6 SET pointerInUse=%pointer6%
IF %selected% == 7 SET pointerInUse=%pointer7%
GOTO :EOF
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 25
::END/changePointer

::---FUNCTION---
:togglePointer
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 26
IF "%isPointerUsed%" == "yes" (
SET isPointerUsed=no
) ELSE (
IF "%isPointerUsed%" == "no" (
SET isPointerUsed=yes)
)

::(below) keep this line as the function is not
::called elsewhere before re-printing the main menu
CALL :returnPointerToStart
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 27
::(below) think of EOF as 'End Of Function' rather 
:: than 'End Of File'
GOTO :EOF                                                                            
::END/togglePointer

REM (below) place small function headers so the programmer
REM know he's looking in the 'FUNCTIONS' sections when
REM he returns to his small window(not monitor)
REM
REM the 'FUNCTIONS' section like other sections
REM serves a programmer navagate this file
REM either on the computer or on paper 

::---FUNCTION---
:revertToDefaultOptions
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 28
::***option variables (default values)***                                       
SET option1="defualt1"
SET option2="defualt2"
SET option3="defualt3"
SET option4="defualt4"
SET option5="defualt5"
SET option6="defualt6"
SET option7="defualt7"
SET option8="defualt8"
SET option9="defualt9"
SET option10="defualt10"
SET option11="defualt11"
SET option12="defualt12"
GOTO :EOF                                                                       IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 29
::END/revertToDefaultOptions

::---FUNCTION---
:returnPointerToStart
::places pointer back to the first option of the
::menu
SET /A selected=%firstOption%
GOTO :EOF
::END/returnPointerToStart

::---FUNCTION---
:examSelectable
::arg 1: option number
::example: 1, 2, 3...
::arg 2: option variable
::example: %option4%, %option5%, %option6%...
::
::(below)line allows only the amount of options requested by the menu
IF %~1 GTR %lastOption% GOTO :EOF
IF %selected% == %~1 ( 
IF "%isPointerUsed%" == "yes" (ECHO %pointerInUse% %~2 
) ELSE (
        ECHO %~2
       )
)
IF NOT %selected% == %~1 (ECHO %~2
)
GOTO :EOF
::END/examSelectable

::---FUNCTION---
:END
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 30
CHOICE /C YN /M "End this program now? (Y - YES/ N - NO)"
IF %ERRORLEVEL% == 1 (
		      ECHO "End of Program"
		      PAUSE
		      REM (below) wanted EXIT to be EXIT /B, but there was a glitch I couldn't
          REM fix at the time
		      EXIT
		     )
                                                                                IF "%debugMode%" == "on" PAUSE & ECHO checkpoint 31
IF %ERRORLEVEL% == 2 GOTO runMainMenu
::END/END


::
::WHY VARIABLES ARE NAMED WHAT
::

::menuTitle:
::    is as said, a title for a menu

::topDecrative:
::    a 'decrative' line that is above the menu title

::bottemDecrative:
::    a 'decrative' line that is below the menu title 


::
::WHY FUNCTIONS ARE NAMED WHAT
::

::runMainMenu & runPointerMenu: 
::    functions that 'run' a group of functions that give a menu functionality
::    in a loop.

::mainMenuPromptOptions & pointerMenuPromptOptions:
::    functions that 'prompt' the user with 'options' to select.

::changePointer:
::    does exactly what it says.

::placePointer:
::    'places' the pointer on the visible menu.

::togglePointer: 'toggles' between the pointer's 2 states of exitence (yes/no)


::
::THINGS THAT WILL NOT WORK IN DOS
::

::1) can't assign a string value containing a '(' to a string variable
::i.e.   SET willNotWork=( a string
::       SET willNotWork=() a string
::       SET willNotWork=(1) a string
::       SET willNotWork=(string) a string
::
::to solve issue:
::       a)put string being assigned in a set of double quotes
::        i.e.   SET willWork="( a string"
::       b)replace single or set of 'curved' brackets
::        i.e.   SET willWork=-string- a string
::       c)if unneeded, remove anything after the 'curved brackets'
::        i.e.   SET willWork=()
::               SET willWork=(string)

::2) can't have a space between the variable being assigned a value and the
::   equal sign unless SET's '/A' switch is used;In which case, your working
::   with numbers
::i.e.   SET willNotWork =value
::       SET willNotWork        =value
::       
::to solve issue:
::      a)eliminate the spaces or tabs (a.k.a white space)
::       i.e.   SET willWork=value
::
::note:
::      this doesn't mean a space can't be between
::      '=' (equals sign) and the string
::      i.e.    SET willWork= value

::3) never place something (exception being the '.') directly after
:: the reserved word 'ECHO' as it will result in an error
::i.e.   ECHOwill not work
::       ECHOstill won't work
::       ECHOyou get the point?
::
::to solve issue:
::     a) place message one space after 'ECHO'
::      i.e.   ECHO will work
::             ECHO still works
::             ECHO got it?

::4) don't place a reserved word before a comment (creates an unexspected
::   effect), nor should you place a comment in front of a command on the same
::   line
::i.e.   won't work: ECHO comment becomes part of this 'ECHO' ::the comment
::       won't work: ::the comment turns anything after it into ignored text.
::                     the ignored: ECHO nooo!!
::       
::examples of working code:
::       works: 
::          (line 1) ::(below) <--have a reference to the code, and comment code
::          (line 2) ECHO option 1
::           note: reference on line 1 is optional, but makes reading comments
::                 easier
::
::       works:
::          (line 1) ECHO option 2
::          (line 2) ::(above) <--have a reference to the code, and comment code
::
::       works(if you really wanted to):
::          (line 1) ECHO option 3
::          (line 2) ::
::          (line 3) :: the comment or more blank comments followed by the comm-
::                   -ment
::
::           note: in case the above examples caused you to doubt your current
::                 knowledge of comments in DOS, you can have unlimited
::                 comments (blank or with text) with out a negative consequence
::                 since the syntax for commenting ('::' as seen used above)
::                 tells the DOS interpreter to ignore(not execute) everything
::                 on the line after the '::'

::5) the reserved word 'IF' has a 'spaceing issue'
::i.e.
::      works:   IF %variable% == "value" (IF %variable% == "value" ECHO works
::                                      )
::
::      why above is correct: there is no more than one space between any 
::         cluster of characters (that includes the reserved word 'IF')
::
::however if their are 2 or more spaces at location A or B an unexspected error
::occures
::      won't work:  IF %variable% == "value"[A](IF %variable% == "value"[B]ECHO opps...
::                                              )
::
::to solve issue:
::      a) go over your code and make sure that there is only a single space
::         after each cluster of characters


::
::UPDATE LOGS
::

::---update V1---
:: 1) working menu made
::
:: 2) coding rules for this documents were added at the top. Hopefully this will
::    encourage developers to write code in a conformed manner that will keep
::    the document organized and readable
::
:: 3) added the "FUNCTIONS" section

::---update V2---
:: 1) a few variables renamed
::
:: 2) added the new 'pointer menu' to switch the pointers look

::---update V3---
:: 1) fixed some bugs
::
:: 2) pointer menu's code is now moderatly cleaner
::
:: 3) replaced all unneeded GOTO statements with CALL statements. As a result, 
::    there are now code block templates for all menus (present, and future
::    menus) are developed. If you don't know what I mean by
::    "code block templates", then think of these templates as code which can be
::    used by multiple things,yet share the same variables.
::    This is important as it saves development time via copy and past, and the
::    code is cleaner since fewer variables are needed to run the menus.
::
:: 4) added "UPDATE LOGS" section
::
:: 5) added "WHY VARIABLES ARE NAMED WHAT" section

::---update V4---
:: 1) added "WHY FUNCTIONS ARE NAMED WHAT" section
::
:: 2) added option to change the menu's interface from 'using a pointer' to
::    'not using a pointer'
::
:: 3) due to the update, the menu is unable to run becuase of new bugs created
::    by this update

::---update V5---
:: 1) added "WHAT NOT TO DO IN DOS" section as a reference (reminder) of some
::    frequent syntactical mistakes and their solutions to help the developer
::    debug their code
::
:: 2) did spelling corrections through out the entire document. however, this
::    doesn't mean that spelling errors (existing durring update V5) are
::    eliminated
::
:: 3) reformated portions of this document such as the 'CODEING RULES' section
::    and comments in the 'FUNCTIONS' section
::
:: 4) code has been partitioned with multiple instances of the reserved word
::    'PAUSE' in order to eliminate the bug. in the partion, multiple instances
::    of 'ECHO', each followed by a diffrent number, to help locate
::    an error in the code
::
::    since the method of partioning the code is going splendidly, i thought the
::    below example would be useful in the future when the partion is removed
::    from the code
::    
::    this is what one line looks like:
::    PAUSE & ECHO pause 1
::
::    note: never use the above line in between functions, nor after a 'CALL' or
::          'GOTO' statement. doing so will prevent some ECHO's of the entire
::          partition from occuring, and you'll be
::          loseing time understanding why/if lines 
::          of code aren't executing

::---update V6---
:: 1) fixed issue that prevented the program from working
::
:: 2) fixed the 'toggle pointer' option on the main
::    menu
::
:: 3) made debugging toggable, but only by changing
::    a variable within the code. the variable can
::    be found near the top of the "INITIAL CODE RUNNED" section. any code
::    that was/is being used for debugging has been made toggable
::
:: 4) changed the available pointers since the origenal pointers that
::    used parentheses ( (+), (-), and (0) ) caused errors that were
::    -by syntax- unfixable. as of now, the mentioned pointers have had 
::    their parenthese replaced with currly bracket 
::    (clossly resembles parenthese). In addition, no future pointer will 
::    consist of parentheses in order to prevent the error from reoccuring
::
:: 5) reformated the if statments in the 'placePointer' function
::
:: 6) introduced a feature that displays the menu title - and its top and
::    bottem decratives - for each available menu. In addition, there are
::    defualt values for the menu title, top decrative, and bottom decrative
::    should those variables not be defined for a given menu
::
:: 7) migrated definitions of functions accidently placed in the
::    "WHY VARIABLES ARE NAMED WHAT" section to the 
::    "WHY FUNCTIONS ARE NAMED WHAT". new definitions have been added
::    to the "WHY VARIABLES ARE NAMED WHAT" section

::---update V7---
:: 1) updated the function 'placePointer' to now have the ability
::    to NOT print (show on console) options that are beyound the amount
::    of option given to a menu
::
:: 2) renamed the 'INITIAL CODE RUNED' section to 'MAIN CODE' since the name
::    is more main stream
::
:: 3) made a change in the 'CODEING RULES' section involving 'mega comments'.
::    'mega comments' have been renamed 'headers' since the name is mainstream
::    in books and e-books that many and is more fitting to it's purpose. all
::    headers have been updated
::
:: 4) swaped top and bottem spacing set in the 'CODEING RULES' section since
::    this makes the header(no longer called mega comment) part of it's contents
::    . in addition, the header example in 'CODEING RULES' section has been
::    enhanced to include a visual for the document's edge
::
:: 5) small amount of code was made more understandable

::---update V8---
:: 1) compacted the 'placePointer' function with 'examSelectable' function calls
::
:: 2) created a 'line break' decrative to visualy seperate groups of related
::    options
::
:: 3) renamed the 'CODEING RULES' section to the 'CODEING FORMAT RULES'.
::    this change is to clarify the purpose of the section is dedicated to
::    custom code formating rules, and does not refer to DOS syntactical rules
::
:: 4) added 'toggle windows' to show the current state of a boolean like (though
::    it doesn't have to limited to that) along side an options text