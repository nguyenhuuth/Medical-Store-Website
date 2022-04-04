

const store = document.getElementById("store");
const btnList = store?.querySelectorAll('button[type="button"]');
let total = 0;

const update = (data) => {
        const wrapper = document.createElement("div");
        total = 0;
        data.forEach((item) => {
                const element = createEntity(item.name, item.quantity, item.retailPrice, item.productId);
                wrapper.appendChild(element);
        });

        const cart = document.getElementById("cart");
        if (cart) {
                const totalElement = createEntity("Total", 1, total, "total");
                cart.innerHTML = "";
                cart.appendChild(wrapper);

                cart.appendChild(totalElement);
        }
};

const createEntity = (name, quantity, price, id) => {
        const plus = document.createElement("div");
        const minus = document.createElement("div");
        plus.classList.add("p-1", "font-semibold");
        minus.classList.add("p-1", "font-semibold");
        plus.innerHTML = "+";
        minus.innerHTML = "-";

        plus.addEventListener("click", function () {
                http.post("/api/cart/add", { productId: id, quantity: 1 }).then((res) => {
                        update(res.data.data);
                });
        });

        minus.addEventListener("click", function () {
                http.post("/api/cart/add", { productId: id, quantity: -1 }).then((res) => {
                        update(res.data.data);
                });
        });
        total += quantity * price;
        const wrapper = document.createElement("div");
        wrapper.classList.add(
                "flex",
                "items-center",
                "block",
                "p-3",
                "transition",
                "duration-300",
                "ease-in-out",
                "bg-white",
                "cursor-pointer",
                "dark:bg-dark-3",
                "hover:bg-gray-200",
                "dark:hover:bg-dark-1"
        );
        const top = document.createElement("div");
        top.classList.add(`w-3/6`, "mr-1", "truncate", "pos__ticket__item-name");
        top.innerHTML = name;
        const bottom = document.createElement("div");
        bottom.classList.add("w-1/6", "ml-auto", "font-medium");
        bottom.innerHTML = `$${price * quantity}`;
        const label = document.createElement("div");
        const buttonWrapper = document.createElement("div");
        buttonWrapper.classList.add("flex", "items-center", "w-1/6", "space-x-2", "add-cart");
        if (id !== "total") {
                buttonWrapper.appendChild(plus);
                buttonWrapper.appendChild(label);
                buttonWrapper.appendChild(minus);
        }

        label.classList.add("text-gray-600");
        label.innerHTML = `${quantity}`;

        wrapper.append(top);
        wrapper.append(buttonWrapper);
        wrapper.append(bottom);
        return wrapper;
};
http.get("/api/cart").then((res) => {
        update(res.data.data);
});

btnList?.forEach((btn) => {
        btn.addEventListener("click", function (event) {
                const id = btn.getAttribute("data-id") || "";
                http.post("/api/cart/add", { productId: id, quantity: 1 }).then((res) => {
                        update(res.data.data);
                });
        });
});

let payment = 0;

const paymentList = document.querySelectorAll('input[name="payment"]');
paymentList.forEach((radio) => {
        radio.addEventListener("click", function () {
                payment = Number(radio.value);
        });
});

const order = document.getElementById("order");
order?.addEventListener("submit", function (event) {
        event.preventDefault();
        http.post("/api/order", { paymentMethod: payment }).then(() => {
                window.location.reload();
        });
});
