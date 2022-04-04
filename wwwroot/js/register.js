const registerForm = document.getElementById("registerForm");
registerForm?.addEventListener("submit", function (event) {
        event.preventDefault();
        const username = document.getElementById("username");
        const password = document.getElementById("password");
        const name = document.getElementById("name");
        const confirmPassword = document.getElementById("confirmPassword") ;
        const phone = document.getElementById("phone");
        const email = document.getElementById("email");
        const address = document.getElementById("address");

        if (
                username !== null &&
                password !== null &&
                name !== null &&
                confirmPassword !== null &&
                phone !== null &&
                email !== null &&
                address !== null
        ) {
                let input = {
                        username: username.value,
                        password: password.value,
                        name: name.value,
                        confirmPassword: confirmPassword.value,
                        phone: phone.value,
                        email: email.value,
                        address: address.value,
                };

                http.post('/api/auth/register', input)
                .then(() => window.location.assign("/auth/login"))
                .catch(function (error) {
                    console.log(error);
                });
        }
});