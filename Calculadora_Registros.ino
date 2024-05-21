bool flagPush1 = 0;
bool flagPush2 = false;
bool flagPush3 = 0;
bool flagPush4 = 0;
bool flagPosition = false;
int y1 = 0;
int y2 = 0;
int y3 = 0;
int y4 = 0;


int contadorD1 = 0;
int contadorD2 = 0;
int contadorD3 = 0;
int contadorD4 = 0;
int position = 1; //Posición del digito a modificar

void setup()
{
  // Definir pines de entrada y salida
  DDRD = B11111111;
  DDRB = B11001111;
  DDRC = B11001111;  
  
}

void loop()
{
  y1++;
  y2++;
  y3++;
  y4++;
  //Encender todos los leds
  //PORTD = B00000000;

  //Endender todos los anodos
  //PORTB = B11111111;
  if(PINB & B00010000)
    flagPosition = true;
  
  if(!(PINB & B00010000) && flagPosition == true)
  {
    position++;
    flagPosition = false;
  }
  if(position > 4)
    position = 1;


  //DISPLAY 4
  if(position == 4)
  {
    PORTB = B00000001;//Anodo D1
    
    //Contador 500 ms  
    if(y4 == 500)
    {
      contadorD4++;
      y4 = 0;
    }


    //Mostrar numeros
    showNumber(contadorD4);
     if(contadorD4 > 9)
        contadorD4 = 0;
  }


  if(position == 3)
  {
    PORTB = B00000010;//Anodo D3

    //Contador 500 ms  
    if(y3 == 500)
    {
      contadorD3++;
       y3 = 0;
    }


    //Mostrar numeros
    showNumber(contadorD3);
     if(contadorD3 > 9)
        contadorD3 = 0;
  }


  if(position == 2)
  {
    PORTB = B00000100;//Anodo D2

    //Contador 500 ms  
    if(y2 == 500)
    {
      contadorD2++;
       y2 = 0;
    }


    //Mostrar numeros
    showNumber(contadorD2);
     if(contadorD2 > 9)
        contadorD2 = 0;
  }

  if(position == 1)
  {
    PORTB = B00001000; //Encender Anodo D1

    //Contador 500 ms  
    if(y1 == 500)
    {
      contadorD1++;
       y1 = 0;
    }


    //Mostrar numeros
    showNumber(contadorD1);
     if(contadorD1 > 9)
        contadorD1 = 0;
  }

  //Velocidad 1ms
  delay(1);
}


void showNumber(int num)
{
  switch(num)
  {
    case 0: 
      PORTD = B00000011;
      break;
    case 1: 
      PORTD = B10011111;
      break;
    case 2: 
      PORTD = B00100101;
      break;
    case 3: 
      PORTD = B00001101;
      break;
    case 4: 
      PORTD = B10011001;
      break;
    case 5: 
      PORTD = B01001001;
      break;
    case 6: 
      PORTD = B01000001;
      break;
    case 7: 
      PORTD = B00011111;
      break;
    case 8: 
      PORTD = B00000001;
      break;
    case 9: 
      PORTD = B00001001;
      break;
  }
}
  
  //PORTB = B00001000; //Encender Anodo D4
  //PORTB = B00000100; //Encender Anodo D3
  //PORTB = B00000010; //Encender Anodo D2
  //PORTB = B00000001; //Encender Anodo D1

  