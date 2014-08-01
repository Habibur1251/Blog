/*
Site URI: http://greenhouse.fedehartman.com
Date: Mar 2010
jQuery Programmer: Fede Hartman - http://fedehartman.com/
*/

$(document).ready(function(){

/*--IE7-WARNING--*/
	var ie7 = '<div id="i_explorer">' +
					'<div id="i_explorer_overlay"></div>' +
					'<div id="i_explorer_content">' +
					'<p class="first">Sorry but&hellip;</p>' +
					'<p>&#8212;This site does not support your Internet Explorer 7 browser.</p>' +
					'<p>&#8212;I recommend you to upgrade to version 8 by <a href="http://www.microsoft.com/latam/windows/internet-explorer/" target="_blank">clicking here</a> to see the site content.</p>' +
					'<p>&#8212;Further recommend that you use <a href="http://www.mozilla-europe.org/es/firefox/" target="_blank">Mozilla Firefox</a>  to surf the Internet.</p>' +
					'<p>&#8212;Thank you :)</p>' +
					'</div>' +
					'<div>';
	if ($.browser.msie && $.browser.version < "8.0") {
		$("body").append(ie7);
	}

/*--LI-CLICKABLE--*/
	$("ul#footer li").click(function(){
		window.location=$(this).find("a").attr("href"); return false;
	});

/*--SLIDER--*/
	$('#main.home').cycle({
		fx: 'fade', 
		speed: 2400,
		timeout: 2400 
	});

/*--LIGHTBOX--*/
	$("a.lightbox").lightbox({
		imageClickClose: true
	});

/*--CLEAR-FORM--*/
	$("textarea#mensaje").DefaultValue('Your message\u2026');
	$("input#nombre").DefaultValue("your name\u2026");
	$("input#correo").DefaultValue("\u2026and your email.");
	
/*--PLAYER--*/
	var so = new SWFObject('js/flvplayer.swf','mpl','405','225','9');
	so.addParam('allowfullscreen','true');
	so.addParam('allowscriptaccess','always');
	so.addParam('wmode','transparent');
	so.addVariable('author','Fede Hartman');
	so.addVariable('description','Planning The Green House');
	so.addVariable('file','http://greenhouse.fedehartman.com/movie/greenhouse.m4v');
	so.addVariable('title','Planning The Green House');
	so.addVariable('provider','Fede Hartman');
	so.addVariable('volume','100');
	so.addVariable('image','http://greenhouse.fedehartman.com/movie/movie.jpg');
	so.addVariable('stretching','exactfit');
	so.write('mediaspace');

}); /*--jQuery--*/

