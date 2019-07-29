var sites = [
    'mosquitoes.html',
];

function randomSite() {
var i = parseInt(Math.random() * sites.length);
location.href = sites[i];
}