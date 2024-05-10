document.getElementById("loginForm").addEventListener("submit", function (event) {
    event.preventDefault();
    var formData = new FormData(this);
    fetch("/Users/Login", {
        method: "POST",
        body: formData
    }).then(function (response) {
        if (response.redirected) {
            window.location.href = response.url;
        }
    });
});