using Moq;
using Xunit;

namespace jarai.tdd4b.Adapter.Tests;

public class UsbChargerToAppleChagerAdapterTests
{
    [Fact]
    public void GivenUsbChargerAdapter_WhenIphoneIsCharged_ThenLiefereStromViaUsbIsCalled()
    {
        // Arrange
        var iphone = new ApplePhone();
        var usbChargerMock = new Mock<UsbCharger>();
        usbChargerMock.Setup( mock => mock.LiefereStromViaUsb()).Returns(500);
        var adapter = new UsbChargerToAppleChagerAdapter(usbChargerMock.Object);

        // Act
        iphone.Charge(adapter);

        // Assert
        usbChargerMock.Verify(charger => charger.LiefereStromViaUsb(), Times.Once);
    }
}