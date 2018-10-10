const version = "0.6.11";
const cacheName = `bbpos-${version}`;
self.addEventListener('install', e => {
    e.waitUntil(
        caches.open(cacheName).then(cache => {
            return cache.addAll([
                `/`,
                `/index.html`,
                `/fetchdata`,
                `/counter`,
                `/static/media/glyphicons-halflings-regular.448c34a5.woff2`,                
                `/static/js/bundle.js`,
                `/sockjs-node/info`
            ])
                .then(() => self.skipWaiting());
        })
    );
});

self.addEventListener('activate', event => {
    console.log("activate");
    event.waitUntil(self.clients.claim());
});

self.addEventListener('fetch', event => {
    event.respondWith(
        caches.open(cacheName)
            .then(cache => cache.match(event.request, { ignoreSearch: true }))
            .then(response => {
                console.log(response);
                return response || fetch(event.request);
            })
    );
});
