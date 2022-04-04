const banForm = document.getElementById("banForm");
banForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const userId = document.getElementById("userId");
    if (userId !== null) {
        let input = {
            userId: userId.value,
        };

        http.post('/api/user/banUnban', input)
            .then(() => window.location.assign('/'))
            .catch(function (error) {
                console.log(error);
            });
    }
});
