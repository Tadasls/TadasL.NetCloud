const addFormBtn = document.querySelector("#addForm");

// Create a break line element
const br = document.createElement("br");

function addForm() {
  // Create a form dynamically
  const form = document.createElement("form");
  form.setAttribute("id", "form");

  // Create an input element for Type
  const id = document.createElement("input");
  id.setAttribute("type", "number");
  id.setAttribute("name", "id");
  id.setAttribute("placeholder", "Id");
  id.setAttribute("id", "id");

  // Create an input element for Type
  const type = document.createElement("input");
  type.setAttribute("type", "text");
  type.setAttribute("name", "type");
  type.setAttribute("placeholder", "Type");
  type.setAttribute("id", "type");

  // Create an input element for Content
  const content = document.createElement("input");
  content.setAttribute("type", "text");
  content.setAttribute("name", "content");
  content.setAttribute("placeholder", "Content");
  content.setAttribute("id", "content");

  // Create an input element for End Date
  const endDate = document.createElement("input");
  endDate.setAttribute("type", "text");
  endDate.setAttribute("name", "endDate");
  endDate.setAttribute("placeholder", "End Date");
  endDate.setAttribute("id", "endDate");

  // Create an input element for Name
  const name = document.createElement("input");
  name.setAttribute("type", "text");
  name.setAttribute("name", "name");
  name.setAttribute("placeholder", "Name");
  name.setAttribute("id", "name");

  // Create the buttons
  const submitBtn = document.createElement("input");
  submitBtn.setAttribute("type", "button");
  submitBtn.setAttribute("value", "Submit");
  submitBtn.setAttribute("id", "submitBtn");

  const editBtn = document.createElement("input");
  editBtn.setAttribute("type", "button");
  editBtn.setAttribute("value", "Edit");
  editBtn.setAttribute("id", "editBtn");

  const deleteBtn = document.createElement("input");
  deleteBtn.setAttribute("type", "button");
  deleteBtn.setAttribute("value", "Delete");
  deleteBtn.setAttribute("id", "deleteBtn");

  // Append the Id input to the form
  form.appendChild(id);
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the Type input to the form
  form.appendChild(type);

  // Inserting a line break
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the Content input to the form
  form.appendChild(content);
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the End Date input to the form
  form.appendChild(endDate);
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the End Date input to the form
  form.appendChild(name);
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the buttons to the form
  form.appendChild(submitBtn);
  form.appendChild(editBtn);
  form.appendChild(deleteBtn);

  document.getElementsByTagName("body")[0].appendChild(form);

  submitBtn.addEventListener("click", (e) => {
    e.preventDefault();
    sendData();
  });

  editBtn.addEventListener("click", (e) => {
    e.preventDefault();
    editData();
  });

  deleteBtn.addEventListener("click", (e) => {
    e.preventDefault();
    deleteData();
  });
}

addFormBtn.addEventListener(
  "click",
  (e) => {
    e.preventDefault();
    addForm();
  },
  { once: true }
);

function sendData() {
  const form = document.querySelector("#form");

  let data = new FormData(form);
  let obj = {};

  data.forEach((value, key) => {
    console.log(`${key}(Key): ${value}(Value)`);
    obj[key] = value;
  });

  fetch("https://testapi.io/api/karoliens/resource/ToDoAppDB", {
    method: "post",
    headers: {
      Accept: "application/json, text/plain, */*",
      "Content-Type": "application/json",
    },

    body: JSON.stringify(obj),
  })
    .then((obj) => console.log(obj.json()))
    .catch((error) => console.log(error));
}

function editData() {
  const form = document.querySelector("#form");

  let data = new FormData(form);
  let obj = {};

  data.forEach((value, key) => {
    obj[key] = value;
  });

  const url = "https://testapi.io/api/karoliens/resource/ToDoAppDB/" + obj.id;

  fetch(url, {
    method: "put",
    headers: {
      Accept: "application/json, text/plain, */*",
      "Content-Type": "application/json",
    },

    body: JSON.stringify(obj),
  })
    .then((obj) => {
      const res = obj.json();
      console.log(res);
      return res;
    })
    .catch((error) => console.log(error));
}