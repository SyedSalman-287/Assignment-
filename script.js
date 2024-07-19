$(document).ready(function() {
    function loadBooks() {
        $.ajax({
            url: 'books.json',
            dataType: 'json',
            success: function(data) {
                $('#book-list').empty();
                data.forEach(function(book) {
                    $('#book-list').append(`
                        <div class="book">
                            <img src="${book.image}" alt="${book.title} cover">
                            <h3>${book.title}</h3>
                            <p>${book.author}</p>
                            <p>${book.description}</p>
                        </div>
                    `);
                });
            }
        });
    }

    function filterBooks(query) {
        $.ajax({
            url: 'books.json',
            dataType: 'json',
            success: function(data) {
                $('#book-list').empty();
                data.filter(book => book.title.toLowerCase().includes(query.toLowerCase())).forEach(function(book) {
                    $('#book-list').append(`
                        <div class="book">
                            <img src="${book.image}" alt="${book.title} cover">
                            <h3>${book.title}</h3>
                            <p>${book.author}</p>
                            <p>${book.description}</p>
                        </div>
                    `);
                });
            }
        });
    }

    $('#search-bar').on('input', function() {
        let query = $(this).val();
        filterBooks(query);
    });

    $('#load-more').click(function() {
        loadBooks();
    });

    loadBooks();
});
