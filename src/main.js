import { createApp } from 'vue'
import App from './App.vue'
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';
import 'bootstrap-icons/font/bootstrap-icons.css'
import router from './router'
import { createStore } from 'vuex';

const store = createStore({
    state(){
        return{
            userName:'',
            isLoggedIn:false,
        }
    }
});


createApp(App).use(router).use(store).mount('#app')
