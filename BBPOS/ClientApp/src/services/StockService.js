import axios from 'axios';

let urlApi = '/api/stock';

let StockService = {
    getStock:function(){
        return axios.get(urlApi);
    },
    updateStock:function (index,cant){
        let obj = {
            index: index,
            cat:cant
        }
        return axios.post(urlApi,obj);
    }
}

module.exports = StockService;
