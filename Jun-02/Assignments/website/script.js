const content = document.getElementById('content');

const homeContent = `
  <h2>Welcome to Dell</h2>
  <p>Exclusive store for laptops, desktops, and accessories.</p>
`;

//model 
const modelsContent = `
  <div class="product-card">
    <img src="images/dell1.jpg" alt="Dell Inspiron 15" />
    <h3>Dell Inspiron 15</h3>
    <p>Price: 65,000</p>
    <button class="add-cart" data-product="Dell Inspiron 15">Add to Cart</button>
  </div>
  <div class="product-card">
    <img src="images/dell2.jpg" alt="Dell XPS 13" />
    <h3>Dell XPS 13</h3>
    <p>Price: 1,47,000</p>
    <button class="add-cart" data-product="Dell XPS 13">Add to Cart</button>
  </div>
`;


//contact
const contactContent = `
  <h2>Contact Us</h2>
  <p>Email: support@dell.com</p>
  <p>Phone: +1 (900) 123-4321</p>
`;

function addCartListeners() {
  const buttons = document.querySelectorAll('.add-cart');
  buttons.forEach(btn => {
    btn.onclick = () => {
      alert(btn.getAttribute('data-product') + " added to cart!");
    };
  });
}


content.innerHTML = homeContent;


document.getElementById('home').onclick = e => {
  e.preventDefault();
  content.innerHTML = homeContent;
  addCartListeners();
};

document.getElementById('models').onclick = e => {
  e.preventDefault();
  content.innerHTML = modelsContent;
};

document.getElementById('contact').onclick = e => {
  e.preventDefault();
  content.innerHTML = contactContent;
};
