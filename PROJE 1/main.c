#include <stdint.h>
#include <stdbool.h>
#include "inc/hw_memmap.h"
#include "inc/hw_types.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"

#define LCD_PORT GPIO_PORTB_BASE
#define LCD_PORT_ENABLE SYSCTL_PERIPH_GPIOB
#define RS GPIO_PIN_0
#define E GPIO_PIN_1
#define D4 GPIO_PIN_4
#define D5 GPIO_PIN_5
#define D6 GPIO_PIN_6
#define D7 GPIO_PIN_7

void LCD_Command(uint8_t cmd);
void LCD_Data(char data);
void LCD_Init(void);
void LCD_String(const char *str);
void LCD_PulseEnable(void);

int main(void) {
    // GPIO portu için saat ayarý
    SysCtlClockSet(SYSCTL_SYSDIV_5 | SYSCTL_USE_PLL | SYSCTL_XTAL_16MHZ | SYSCTL_OSC_MAIN);
    SysCtlPeripheralEnable(LCD_PORT_ENABLE);

    // LCD pinlerini çýkýþ olarak ayarla
    GPIOPinTypeGPIOOutput(LCD_PORT, RS | E | D4 | D5 | D6 | D7);

    // LCD'yi baþlat
    LCD_Init();

    // LCD'ye "SEMIH" yazýsýný göster
    LCD_String("SEMIH");

    while (1) {
        // Programýn sürekli çalýþmasýný saðlamak için sonsuz döngü
    }
}

void LCD_Init(void) {
    SysCtlDelay(50000); // LCD'nin açýlmasý için bekleme

    // LCD'yi 4-bit modda baþlat
    LCD_Command(0x03);
    SysCtlDelay(50000);
    LCD_Command(0x03);
    SysCtlDelay(50000);
    LCD_Command(0x03);
    LCD_Command(0x02);

    // LCD ayarlarý
    LCD_Command(0x28); // 4-bit mod, 2 satýr, 5x8 font
    LCD_Command(0x0C); // Ekran AÇIK, Ýmleç KAPALI
    LCD_Command(0x06); // Ýmleci ilerlet
    LCD_Command(0x01); // Ekraný temizle
    SysCtlDelay(50000); // Komutun tamamlanmasý için bekleme
}

void LCD_Command(uint8_t cmd) {
    GPIOPinWrite(LCD_PORT, RS, 0x00); // Komut için RS = 0

    // Üst nibble'ý gönder
    GPIOPinWrite(LCD_PORT, D4 | D5 | D6 | D7, (cmd & 0xF0));
    LCD_PulseEnable();

    // Alt nibble'ý gönder
    GPIOPinWrite(LCD_PORT, D4 | D5 | D6 | D7, (cmd << 4) & 0xF0);
    LCD_PulseEnable();

    SysCtlDelay(50000); // Komutun tamamlanmasý için bekleme
}

void LCD_Data(char data) {
    GPIOPinWrite(LCD_PORT, RS, RS); // Veri için RS = 1

    // Üst nibble'ý gönder
    GPIOPinWrite(LCD_PORT, D4 | D5 | D6 | D7, (data & 0xF0));
    LCD_PulseEnable();

    // Alt nibble'ý gönder
    GPIOPinWrite(LCD_PORT, D4 | D5 | D6 | D7, (data << 4) & 0xF0);
    LCD_PulseEnable();

    SysCtlDelay(50000); // Verinin yazýlmasý için bekleme
}

void LCD_String(const char *str) {
    while (*str) {
        LCD_Data(*str++);
    }
}

void LCD_PulseEnable(void) {
    GPIOPinWrite(LCD_PORT, E, E);
    SysCtlDelay(1000); // Kýsa bir bekleme
    GPIOPinWrite(LCD_PORT, E, 0x00);
    SysCtlDelay(1000); // Kýsa bir bekleme
}
