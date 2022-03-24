export default function getIdFromRoute() {
    return +window.location.pathname.split('/')[window.location.pathname.split('/').length - 1]!;
}