var imageFile

const image = document.getElementById("image");
image?.addEventListener("change", function () {
        const reader = new FileReader();
        reader.onload = function () {
                const dataURL = reader.result;
                const output = document.getElementById("image-preview");
                if (output) {
                        output.src = dataURL;
                }
        };
        const input = this;
        if (input && input.files) {
                imageFile = input.files[0];
                console.log(imageFile);
                reader.readAsDataURL(imageFile);
        }
}); 
const createForm = document.getElementById("createForm");
createForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const name = document.getElementById("name");
    const description = document.getElementById("description");
    const originalPrice = document.getElementById("originalPrice");
    const retailPrice = document.getElementById("retailPrice");
    const quantity = document.getElementById("quantity");
    const categoryId = document.getElementById("categoryId");


    if (
        name !== null &&
        description !== null &&
        originalPrice !== null &&
        retailPrice !== null &&
        quantity !== null &&
        categoryId !== null
    ) {

        const formData = new FormData();
        
        formData.append("name", name.value);
        formData.append("description", description.value);
        formData.append("originalPrice", originalPrice.value);
        formData.append("retailPrice", retailPrice.value);
        formData.append("quantity", quantity.value);
        formData.append("file", imageFile);
        formData.append("categoryId", categoryId.value);

        http.post('/api/product/create', formData, {headers:{ Accept: 'application/x-www-form-urlencoded'}})
            .then(() => window.location.assign("/product/"))
            .catch(function (error) {
                console.log(error);
            });
    }
});