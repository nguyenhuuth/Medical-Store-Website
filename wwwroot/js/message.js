

function requestInterceptor(req) {
        const message = document.getElementById("MESSAGEERROR");
        const errorMessage = document.getElementById("ERRORMESSAGEERROR");

        for (const key in req.data) {
                const error = document.getElementById(`${key.toUpperCase()}ERROR`);
                if (error) {
                        error.innerHTML = ``;
                }
        }

        if (errorMessage) {
                errorMessage.innerHTML = "";
        }
        if (message) {
                message.innerHTML = "";
        }

        return req;
}


function responseSuccessInterceptor(response) {

        if (response?.data?.details?.message) {
                const message = document.getElementById("MESSAGEERROR");
                if (message) {
                        message.innerHTML = response?.data?.details?.message;
                }
        }
        return response;
}
function responseFailedInterceptor(error) {

        if (error.response?.data?.details) {
                const details = error.response.data.details;
                for (const key in details) {
                        const error = document.getElementById(`${key.toUpperCase()}ERROR`);

                        if (error) {
                                error.innerHTML = `${error.getAttribute("data-label")} ${details[key]}`;
                        }

                        if (error && (key === "errorMessage" || key === "message")) {
                                error.innerHTML = `${details[key]}`;
                        }
                }
        }

        return Promise.reject(error.response);
}

const http = axios;
http.defaults.withCredentials = true;

http.interceptors.request.use(requestInterceptor);
http.interceptors.response.use(responseSuccessInterceptor, responseFailedInterceptor);
