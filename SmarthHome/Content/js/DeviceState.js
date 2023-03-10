function DeviceState(DeviceId) {

    var device;

    var room = document.getElementById('room');

    switch (DeviceId) {

        case 1:
            device = document.getElementById('camera');
            break;
        case 2:
            device = document.getElementById('light');
            break;
        case 3:
            device = document.getElementById('conditioner');
            break;
        case 4:
            device = document.getElementById('curtains');
            break;
        case 5:
            device = document.getElementById('tv');
            break;
        default:
    }


    var settings = {
        "url": "/api/RoomDeviceControll?RoomId=" + room.value + "&DeviceId=" + DeviceId + "&IsActive=" + device.checked,
        "method": "POST",
        "timeout": 0,
    };

    $.ajax(settings).done(function (response) {
        console.log(response);
    });


}