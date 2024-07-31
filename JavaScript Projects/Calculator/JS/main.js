const Calculator = {
  Display_Value: '0',
  First_Operand: null,
  Wait_Second_Operand: false,
  operator: null,
}; //defining the calculator object with values.

function Input_Digit(digit) {
  const { Display_Value, Wait_Second_Operand } = Calculator;
  if (Wait_Second_Operand === true) {
    Calculator.Display_Value = digit;
    Calculator.Wait_Second_Operand = false;
  } else {
    Calculator.Display_Value =
      Display_Value === '0' ? digit : Display_Value + digit;
  }
} //displays the pushed digit to the screen, checking if it should replace a '0' or add to a string of digits. also sets Wait_Second_Operand to false.

function Input_Decimal(dot) {
  if (Calculator.Wait_Second_Operand === true) return;
  if (!Calculator.Display_Value.includes(dot)) {
    Calculator.Display_Value += dot;
  } //returning nothing if we press '.' after an operator, or adding a '.' if there isn't already one on the display.
}

function Handle_Operator(Next_Operator) {
  const { First_Operand, Display_Value, operator } = Calculator;
  const Value_of_Input = parseFloat(Display_Value);
  if (operator && Calculator.Wait_Second_Operand) {
    Calculator.operator = Next_Operator;
    return;
  }
  if (First_Operand == null) {
    Calculator.First_Operand = Value_of_Input;
  } else if (operator) {
    const Value_Now = First_Operand || 0;
    let result = Perform_Calculation[operator](Value_Now, Value_of_Input);
    result = Number(result).toFixed(9);
    result = (result * 1).toString();
    Calculator.Display_Value = parseFloat(result);
    Calculator.First_Operand = parseFloat(result);
  }
  Calculator.Wait_Second_Operand = true;
  Calculator.operator = Next_Operator;
} //saves current Display_Value as Value_of_Input. Checks if Wait_Second_Operand and operator are both true (if so, replaces operand with pressed button and exits function.)
//checks is First_Operand is null: if so, is assigns it Value_of_Input.
//If First_operand isn't null, and operator already exists: sets a constant Value_Now to First_Operand (unless it's undefined or otherwise falsy, then it assigns 0). Then it assigns 'result' the value of the calculation using the appropriate function in Perform_Calculation. Gives it numbers after the decimal, makes it a string, and  parses it back to a float which it assigns to Calculator.Display_Value and Calculator.First_Operand.
//Then it sets Calculator.Wait_Second_Operand to true, Calculator.operator to Next_Operator.

const Perform_Calculation = {
  '/': (First_Operand, Second_Operand) => First_Operand / Second_Operand,
  '*': (First_Operand, Second_Operand) => First_Operand * Second_Operand,
  '+': (First_Operand, Second_Operand) => First_Operand + Second_Operand,
  '-': (First_Operand, Second_Operand) => First_Operand - Second_Operand,
  '=': (First_Operand, Second_Operand) => Second_Operand,
}; //an object with basic math functions.

function Calculator_Reset() {
  Calculator.Display_Value = '0';
  Calculator.First_Operand = null;
  Calculator.Wait_Second_Operand = false;
  Calculator.operator = null;
} //sets calculator object back to it's initial state.

function Update_Display() {
  const display = document.querySelector('.calculator-screen');
  display.value = Calculator.Display_Value;
} //sets the calculator-screen to Calculator.Dosplay_Value

Update_Display();
// calls Update_Display

const keys = document.querySelector('.calculator-keys');
keys.addEventListener('click', (event) => {
  const { target } = event;
  if (!target.matches('button')) {
    return;
  }
  if (target.classList.contains('operator')) {
    Handle_Operator(target.value);
    Update_Display();
    return;
  }
  if (target.classList.contains('decimal')) {
    Input_Decimal(target.value);
    Update_Display();
    return;
  }
  if (target.classList.contains('all-clear')) {
    Calculator_Reset();
    Update_Display();
    return;
  }
  Input_Digit(target.value);
  Update_Display();
}); // adds an event listiner for when the buttons are pressed (exits function if other thigs are pressed). Calls different functions depending on button pressed (operators, decimal, all-clear, or a digit)
