function load(pageURL, cssSelector){ if(typeof(pageURL) != typeof(string) || typeof(cssSelector) != typeof(string)){return;}$(cssSelector).load(pageURL);}
function doit(){$("#internal-html").load("../Notes/Parent_WebSite_CSS_Notes.txt");}