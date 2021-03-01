const express = require('express');
const app = express();
const port = 3000;

// Setting up the public directory
app.use(express.static('src'));

app.get('/', (req, res) => {
    res.sendFile('./sec/index.html', { root: __dirname });
});


app.listen(port, () => console.log(`listening on port ${port}!`));