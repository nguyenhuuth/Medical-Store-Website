const updateForm = document.getElementById("updateForm");
updateForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const categoryId = document.getElementById("categoryId");
    const name = document.getElementById("name");
    const description = document.getElementById("description");

    if (
        categoryId !== null &&
        name !== null &&
        description !== null
    ) {
        let input = {
            categoryId: categoryId.value,
            name: name.value,
            description: description.value,
        };

        http.post('/api/category/update/', input)
            .then(() => window.location.assign('/category'))
            .catch(function (error) {
                console.log(error);
            });
    }
});

