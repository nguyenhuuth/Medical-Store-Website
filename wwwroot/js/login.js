

const loginForm = document.getElementById("loginForm");
console.log(loginForm);
loginForm?.addEventListener("submit", function (event) {
        event.preventDefault();
        const username = document.getElementById("username");
        const password = document.getElementById("password");

        if (username !== null && password !== null) {
                let input = {
                        username : username.value,
                        password : password.value,
                };

                http.post('/api/auth/login', input)
                .then(() => window.location.assign('/'))
                .catch(function (error) {
                        console.log(error);
                });
        }
});