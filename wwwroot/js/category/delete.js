
const deleteForm = document.getElementById("deleteForm");
deleteForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const categoryId = document.getElementById("categoryId");
    if (categoryId !== null) {
        let input = {
            categoryId: categoryId.value,
        };

        http.post('/api/category/delete', input)
            .then(() => window.location.assign('/category'))
            .catch(function (error) {
                console.log(error);
            });
    }
});


