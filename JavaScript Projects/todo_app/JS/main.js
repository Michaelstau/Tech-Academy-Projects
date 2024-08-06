/* function that returns an array. if local storage has a todo key, then the function parses it's value and returns it (admitedly, it could not be an array if something else is there, like an object). */
function getTodos() {
  var todos = new Array;
  var todos_str = localStorage.getItem('todo');
  if (todos_str !== null) {
    todos = JSON.parse(todos_str);
  }
  return todos
}

/* function sets variables for the value of our "tasks" element, and the array returned from getTodos function.
it pushes the tasks value to the array, stringifies the array, and sets the local storage to this new value (essentially adding one item to the stringified array in local storage.
then it set the task elements value to "", calls show(), and returns false.)*/
function add() {
  var task = document.getElementById('task').value;
  var todos = getTodos();
  todos.push(task)
  localStorage.setItem('todo', JSON.stringify(todos));
  document.getElementById('task').value = "";
  show();
  return false;
}

/* gets the todos array using getTodos(), splices out item at index value given in props, stringifies the list and saves it locally with key todo, and calls show(). */
function remove(i) {
  var todos = getTodos();
  todos.splice(i, 1);
  localStorage.setItem('todo', JSON.stringify(todos));
  show()
}

/* function gets the todo array using get_todos(), and sets up a string variable which it adds to until it's formatted correctly to be read as an html unordered list containing a list item and buttong for each item in the todo array. It puts the string into the "todos" element */
function show() {
  var todos = getTodos();
  var html = '<ul>';
  for (var i = 0; i < todos.length; i++) {
    html += '<li>'+todos[i]+'<button class="remove" id="'+i+'" onclick=(remove('+i+'))>x</button></li>';
  };
  html += '<ul>';
  document.getElementById('todos').innerHTML = html;
}

/* event listiner listening for a click on the add element, calls teh add function. */
document.getElementById('add').addEventListener('click', add);

/* calls the show function, so any locally save list items are displayed */
show()
