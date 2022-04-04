const deleteForm = document.getElementById("deleteForm");
deleteForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const productId = document.getElementById("productId");
    if (productId !== null) {
        const formData = new FormData();
        formData.append("productId", productId.value);

        http.post('/api/product/delete', formData, { headers: { Accept: 'application/x-www-form-urlencoded' } })
            .then(() => window.location.assign('/product'))
            .catch(function (error) {
                console.log(error);
            });
    }
});
