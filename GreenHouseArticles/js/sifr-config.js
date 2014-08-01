var din = { src: 'js/din.swf'};
var dinbold = { src: 'js/dinbold.swf'};

sIFR.activate(din);
sIFR.activate(dinbold);

sIFR.replace(din, {
  selector: 'ul#footer li h5 a',
  css: '.sIFR-root { color: #ebece6; font-size: 1em;}',
  wmode: 'transparent',
});

sIFR.replace(dinbold, {
  selector: 'section#about h3, section#planning h3, section#environment h3, section#contact h3',
  css: '.sIFR-root { color: #fbfbf7; font-size: 1.25em; outline-style: none; cursor: pointer;}',
  wmode: 'transparent',
});