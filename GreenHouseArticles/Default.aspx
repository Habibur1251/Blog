<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>The Green Article Site</title>

	<meta charset="utf-8" />

	<meta name="Title" content="The Green Article " />
	<meta name="Description" content="The article site about Green Energy, its necessity. " />
	<meta name="Keywords" content="green, house, environment, planning, ecology, energy, save, consumption, weather, houses, country, html 5" />
	<meta name="robots" content="all" />

	<link rel="index" title="The Green House" href="default.aspx" />
	<link rel="next" title="Articles | The Green Articles" href="Articles.aspx" />
	<link rel="bookmark" title="The Green House" href="default.aspx" />

	<link rel="stylesheet" href="css/greenhouse.css" />
	<link rel="shortcut icon" href="favicon.ico">

	<!--[if IE]><script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script><![endif]-->

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <header>

		<div class="wrapper">

		<hgroup>
			<h1><a href="default.aspx" title="Home"><span class="gg" >The Green House Article Store</span></a></h1>
			<h2><span class="gg" >Articles About Green Enviorment and Its Effects on the World</span></h2>
		</hgroup>  

		<nav>
			<ul>
				<li class="nav_home"><a class="active" href="default.aspx" title="Home"><span class="gg" >Home</span></a></li>
				<li class="nav_about"><a href="Articles.aspx?id=0&pageid=1" title="Articles"><span class="gg" >Articles</span></a></li>
				<li class="nav_planning"><a href="submit_articles.aspx" title="Submit Articles"><span class="gg" >Submit Articles</span></a></li>
				<li class="nav_environment"><a href="membership.aspx" title="Membership"><span class="gg" >Membership</span></a></li>
			</ul>
		</nav>  

		</div> <!--"wrapper" -->

	</header>


<!--*|MAIN|****************************************************************************************************************************************************************↓↓↓**/-->

	<div id="container">

		<div id="cuestiones"></div> <!--the curve thing -->

		<div id="main" class="home"> <!--background photos -->
			<img src="img/main_home_1.jpg" width="1200" height="615" alt="Green Articles" class="active"/>
			<img src="img/main_home_2.jpg" width="1200" height="615" alt="Green Articles" class="none"/>
			<img src="img/main_home_3.jpg" width="1200" height="615" alt="Green Articles" class="none"/> 
		</div>

		<section id="home">
			<h3><span class="gg" >Weather erat consectetur ut apien lacus stripping mattis adipiscing</span></h3>
		</section>

	</div> <!--"container" -->


<!--*|FOOTER|**************************************************************************************************************************************************************↓↓↓**/-->

	<footer>

		<div class="wrapper">

		<ul id="footer">
			<li class="footer_company">
				<h5><a href="Articles.aspx" title="About">· The Articles</a></h5>
					<p>· Learn about Green Energy</p>
					<p>· Why we need it</p>
			</li>
			<li class="footer_planning">
				<h5><a href="planning.html" title="Planning">· Planning</a></h5>
					<p>· Weatherstripping from scratch</p>
					<p>· Professionals at your disposal</p>
			</li>
			<li class="footer_environment">
				<h5><a href="environment.html" title="Environment">· Environment</a></h5>
					<p>· Build your Green House</p>
					<p>· Choose different environments</p>
			</li>
			<li class="footer_contact">
				<h5><a href="contact.html" title="Contact">· Contact</a></h5>
					<p>· Send us a message</p>
					<p>· Visit us at our showrooms</p>
			</li>
		</ul> <!--"footer" -->

		<h6 class="left">&copy; 2009 - 2010 &nbsp;<a href="default.aspx" title="Home">The Green House</a>  &nbsp;| &nbsp; Icons by <a href="http://dellustrations.com/" title="Dellustrations" target="_blank">Dellustrations</a></h6>
		<h6 class="right">Development &amp; Design: <a class="footer_logo" href="http://fedehartman.com/en" title="Green Articles">Green Articles</a></h6>

		</div> <!--"wrapper" -->

	</footer>


<!--*|SCRIPTS|*************************************************************************************************************************************************************↓↓↓**/-->

	<!--jQuery-->
		<script src="../code.jquery.com/jquery-1.4.1.min.js" type="text/javascript"></script>
		<script src="js/greenhouse.js" type="text/javascript"></script>
		<script src="js/sifr.js" type="text/javascript"></script>
		<script src="js/sifr-config.js" type="text/javascript"></script>
		<script src="js/cycle.js" type="text/javascript"></script>
		<script src="js/swfobject.js" type="text/javascript"></script>
		<script src="js/lightbox.js" type="text/javascript"></script>
		<script src="js/form-defaults.js" type="text/javascript"></script>

	<!--Google Analytics-->
		<script type="text/javascript">
		    var gaJsHost = (("https:" == document.location.protocol) ? "https://ssl." : "http://www.");
		    document.write(unescape("%3Cscript src='" + gaJsHost + "google-analytics.com/ga.js' type='text/javascript'%3E%3C/script%3E"));
		</script>
		<script type="text/javascript">
		    try {
		        var pageTracker = _gat._getTracker("UA-15502193-1");
		        pageTracker._trackPageview();
		    } catch (err) { }
		</script>

    </div>
    </form>
</body>
</html>
