const apiUrl = "/api/IdeaInMotionComments";

$(function() {

    $("#new-comment-field").richText();

    if ($("#Id").length && $(".comments-container").length) getComments($("#Id").val());

    $(".save-comment").on("click",
        function() {
            const comment = $("#new-comment-field").val();

            if (comment != "" && comment != "<div><br></div>") {
                createComment($("#Id").val(), comment);
            }
        });

    $("#ideainmotion-files").on("change",
        function() {
            const container = $(".file-container .default");
            const files = this.files;

            if (files.length == 1) {
                const extension = getFileExtension(files[0].name);

                if (!isValidExtension(extension)) {
                    $("#attachedfiles-validator").text(`Extension file .${extension} not supported`);
                    return;
                }

                $("#attachedfiles-validator").text("");

                container.text("Selected File: " + files[0].name);
            }


            let containerText = "";
            for (let i = 0; i < files.length; i++) {
                const extension = getFileExtension(files[i].name);

                if (!isValidExtension(extension)) {
                    $("#attachedfiles-validator").text(`Extension file .${extension} not supported`);
                    containerText = "";
                    return;
                }

                $("#attachedfiles-validator").text("");

                containerText += containerText == "" ? files[i].name : ", " + files[i].name;
            }

            container.text("Selected Files: " + containerText);
        });

    formatToLocalTime();
});

function formatToLocalTime() {
    const $dates = $(".local-time-item");

    const dateOptions = {
        weekday: "long",
        year: "numeric",
        month: "long",
        day: "numeric"
    };

    if ($dates) {
        $.each($dates,
            function(i, e) {
                const $item = $(e);

                const localDate = $item.data("date");

                if (localDate) {
                    const newDate = new Date(localDate);

                    const formattedDate = newDate.toLocaleDateString(undefined, dateOptions);

                    $item.text(formattedDate);
                }
            });
    }
}

function getFileExtension(filename) {
    if (filename == null || filename == "") return "";

    const extension = filename.split(".").pop();

    return extension == filename ? "" : extension;
}

function isValidExtension(extension) {

    if (extension == null || extension == "") return false;

    const invalidExtensions = ["exe", "zip", "rar", "bat", "bin"];

    return (invalidExtensions.indexOf(extension)) >= 0 ? false : true;
}

function genericAJAX(url, method, data) {

    return $.ajax({
        url: url,
        method: method,
        contentType: "application/json",
        data: data
    });
}

function showComments(json, containerId) {
    const container = document.getElementById(containerId);

    container.innerHTML = "";

    json.forEach(e => {
        let media = createDOMElement("li", ["media"], "", "", {});

        let initials = createDOMElement("span", ["media-name", "pull-left"], e.createdByInitials, "text", {});

        let mediaBody = createDOMElement("div", ["media-body"], "", "", {});

        let mediaTitle = createDOMElement("span", ["media-title"], "", "", {});

        let mediaAuthor =
            createDOMElement("span", ["text"], e.createdByFirstName + " " + e.createdByLastName, "text", {});

        let mediaDate = createDOMElement("span",
            ["text-muted"],
            e.creationDateFormatted,
            "text",
            { "title": e.creationDateFormatted });

        let comment = createDOMElement("p", [], e.text, "html", {});

        mediaTitle.appendChild(mediaAuthor);
        mediaTitle.appendChild(mediaDate);

        mediaBody.appendChild(mediaTitle);
        mediaBody.appendChild(comment);

        media.appendChild(initials);
        media.appendChild(mediaBody);

        container.appendChild(media);
    });
}

function createDOMElement(element, classes, text, type, attributes) {
    const tag = document.createElement(element);

    if (type == "text") tag.innerText = text;
    else if (type == "html") tag.innerHTML = text;

    classes.forEach(c => tag.classList.add(c));

    for (let key in attributes) tag.setAttribute(key, attributes[key]);

    return tag;
}

function createComment(ideaInMotionId, comment) {

    const viewModel = {
        'Text': comment,
        'IdeaInMotionId': parseInt(ideaInMotionId)
    };

    let commentRequest = genericAJAX(apiUrl, "POST", JSON.stringify(viewModel));

    commentRequest.then(() => {
        $("#new-comment-field").val("");
        $(".richText-editor").html("");

        getComments($("#Id").val());
    });
}

function getComments(ideaInMotionId) {
    let comments = genericAJAX(apiUrl + "/" + ideaInMotionId, "GET", "");

    comments.then(json => {
        showComments(json, "comments-container-list");
    });
}