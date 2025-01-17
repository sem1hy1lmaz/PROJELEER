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
    // GPIO portu i�in saat ayar�
    SysCtlClockSet(SYSCTL_SYSDIV_5 | SYSCTL_USE_PLL | SYSCTL_XTAL_16MHZ | SYSCTL_OSC_MAIN);
    SysCtlPeripheralEnable(LCD_PORT_ENABLE);

    // LCD pinlerini ��k�� olarak ayarla
    GPIOPinTypeGPIOOutput(LCD_PORT, RS | E | D4 | D5 | D6 | D7);

    // LCD'yi ba�lat
    LCD_Init();

    // LCD'ye "SEMIH" yaz�s�n� g�ster
    LCD_String("SEMIH");

    while (1) {
        // Program�n s�rekli �al��mas�n� sa�lamak i�in sonsuz d�ng�
    }
}

void LCD_Init(void) {
    SysCtlDelay(50000); // LCD'nin a��lmas� i�in bekleme

    // LCD'yi 4-bit modda ba�lat
    LCD_Command(0x03);
    SysCtlDelay(50000);
    LCD_Command(0x03);
    SysCtlDelay(50000);
    LCD_Command(0x03);
    LCD_Command(0x02);

    // LCD ayarlar�
    LCD_Command(0x28); // 4-bit mod, 2 sat�r, 5x8 font
    LCD_Command(0x0C); // Ekran A�IK, �mle� KAPALI
    LCD_Command(0x06); // �mleci ilerlet
    LCD_Command(0x01); // Ekran� temizle
    SysCtlDelay(50000); // Komutun tamamlanmas� i�in bekleme
}

void LCD_Command(uint8_t cmd) {
    GPIOPinWrite(LCD_PORT, RS, 0x00); // Komut i�in RS = 0

    // �st nibble'� g�nder
    GPIOPinWrite(LCD_PORT, D4 | D5 | D6 | D7, (cmd & 0xF0));
    LCD_PulseEnable();

    // Alt nibble'� g�nder
    GPIOPinWrite(LCD_PORT, D4 | D5 | D6 | D7, (cmd << 4) & 0xF0);
    LCD_PulseEnable();

    SysCtlDelay(50000); // Komutun tamamlanmas� i�in bekleme
}

void LCD_Data(char data) {
    GPIOPinWrite(LCD_PORT, RS, RS); // Veri i�in RS = 1

    // �st nibble'� g�nder
    GPIOPinWrite(LCD_PORT, D4 | D5 | D6 | D7, (data & 0xF0));
    LCD_PulseEnable();

    // Alt nibble'� g�nder
    GPIOPinWrite(LCD_PORT, D4 | D5 | D6 | D7, (data << 4) & 0xF0);
    LCD_PulseEnable();

    SysCtlDelay(50000); // Verinin yaz�lmas� i�in bekleme
}

void LCD_String(const char *str) {
    while (*str) {
        LCD_Data(*str++);
    }
}

void LCD_PulseEnable(void) {
    GPIOPinWrite(LCD_PORT, E, E);
    SysCtlDelay(1000); // K�sa bir bekleme
    GPIOPinWrite(LCD_PORT, E, 0x00);
    SysCtlDelay(1000); // K�sa bir bekleme
}
