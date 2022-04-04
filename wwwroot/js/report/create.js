const createForm = document.getElementById("createForm");
createForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const productId = document.getElementById("productId");
    const description = document.getElementById("description");

    if (
        productId !== null &&
        description !== null
    ) {
        let input = {
            productId: productId.value,
            description: description.value,
        };

        http.post('/api/report/create', input)
            .then(() => window.location.assign('/order'))
            .catch(function (error) {
                console.log(error);
            });
    }
});