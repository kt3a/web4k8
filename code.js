var sites = [
    'mosquitoes.html',
    'oranges.html'
];

function randomSite() {
var i = parseInt(Math.random() * sites.length);
location.href = sites[i];
}