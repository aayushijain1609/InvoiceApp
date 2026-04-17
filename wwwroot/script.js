document.addEventListener('DOMContentLoaded', function() {
    fetch('/api/invoice')
        .then(response => {
            if (!response.ok) throw new Error('Failed to fetch');
            return response.json();
        })
        .then(data => {
            let html = `
                <h2>Services</h2>
                <ul>`;
            
            data.items.forEach(item => {
                html += `<li>${item.name} - ₹${item.price}</li>`;
            });

            html += `</ul>
                <p><strong>Total: ₹${data.items.reduce((sum, item) => sum + item.price, 0)}</strong></p>`;
            
            document.getElementById('invoice-container').innerHTML = html;
        })
        .catch(error => {
            console.error("Failed to load invoice:", error);
            document.getElementById('invoice-container').innerHTML = "<p style='color:red'>Failed to load invoice. Please check API.</p>";
        });
});
