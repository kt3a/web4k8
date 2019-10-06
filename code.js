var sites = [
    'mosquitoes.html',
    'oranges.html',
    'index.html'
];

function randomSite() {
var i = parseInt(Math.random() * sites.length);
location.href = sites[i];
}