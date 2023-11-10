function ScrollToEnd() {
    let element = document.getElementById('chatDiv');
    element.scrollTo(0, element.scrollHeight);
}

function GetScreenHeightFromJS() {
    return window.innerHeight;
}
