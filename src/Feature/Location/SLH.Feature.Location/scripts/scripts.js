var j = jQuery.noConflict();
var postUpdateUrl = "slh_api/locationApi/UpdatePoi";

//containers
var classImageMap = ".map-image";
var dialogCreate = "div#dialogCreate";
var dialogInfo = "div#dialogInfo";

var spanError = "span#error-message";
var spanInfo = "span#spanInfo";


//form fields
var txtTitle = "#txtTitle";
var txtTop = "#txtTop";
var txtLeft = "#txtLeft";

var hdnMapId = "#hdnMapId";
var hdnWidth = "#hdnWidth";
var hdnHeight = "#hdnHeight";

var formId = "#mapsForm";
var fromName = "mapsForm";

var debug = false;

function OnFailure(response) {
    console.log(response);
}

function updateData(id, top, left) {

    j.ajax({
        type: "POST",
        url: postUpdateUrl,
        data:
            "{" +
                "id: \"" + id + "\"," +
                "top: \"" + top + "\"," +
                "left: \"" + left + "\"" +
                " }",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        failure: OnFailure,
        error: OnFailure
    });
}

//document - ready
j(document).ready(function () {
    
    j(".click").on("click",
        function (e) {
            e.preventDefault();
            return false;
        });

    j(".click").on("mouseup",
        function (e) {
            e.preventDefault();
            var target = j(e.currentTarget);
            if (!target.hasClass('no-click')) {
                parent.scForm.postRequest('', '', '', 'item:load(id=' + target.attr('href') + ')');
            }
        });

    // target elements with the "draggable" class
    interact('.draggable')
		.draggable({
		    // enable inertial throwing
		    inertia: true,
		    // keep the element within the area of it's parent
		    restrict: {
		        restriction: "parent",
		        endOnly: true,
		        elementRect: { top: 0, left: 0, bottom: 1, right: 1 }
		    },
		    // enable autoScroll
		    autoScroll: true,

		    // call this function on every dragmove event
		    onstart: function (event) {
		        var anchor = event.target.querySelector("a");
		        j(anchor).addClass('no-click');
		    },
		    onmove: dragMoveListener,
		    onend: function (event) {

		        var id = event.target.getAttribute('data-id');
		        var top = event.target.getAttribute('data-y') * 100 / j('.map-image').height();
		        var left = event.target.getAttribute('data-x') * 100 / j('.map-image').width();

		        updateData(id, top, left);

		        var anchor = event.target.querySelector("a");
		        j(anchor).removeClass('no-click');
		    }
		});
});

function dragMoveListener(event) {
    var target = event.target,
        // keep the dragged position in the data-x/data-y attributes
        x = (parseFloat(target.getAttribute('data-x')) || 0) + event.dx,
        y = (parseFloat(target.getAttribute('data-y')) || 0) + event.dy;


    var xp = x - j(event.target).width() / 2;
    var yp = y - j(event.target).height();

    target.style.top = '';
    target.style.left = '';

    // translate the element
    target.style.webkitTransform =
        target.style.transform =
        'translate(' + xp + 'px, ' + yp + 'px)';

    // update the posiion attributes
    target.setAttribute('data-x', x);
    target.setAttribute('data-y', y);
}

// this is used later in the resizing and gesture demos
window.dragMoveListener = dragMoveListener;



