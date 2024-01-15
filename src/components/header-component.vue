<template>
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark d-flex justify-content-between">
  <a class="navbar-brand ml-5 mx-2" href="#">Netflix Watchlist</a>
  <div class="navbar-item mx-2" id="login">
    <login-component :style="{display:this.$store.state.isLoggedIn ? 'none' : 'block'}"></login-component>
    <div :style="{display:this.$store.state.isLoggedIn ? 'block' : 'none'}" class="text-right text-light">
      <span>Hola, <b>{{ this.$store.state.userName }}</b>. ¿Qué quieres ver hoy?</span>
      <br>
      <span @click="logOut" style="cursor:pointer" class="d-flex justify-content-end">Cerrar sesión</span>
    </div>
  </div>
</nav>
</template>
  
<script>
import LoginComponent from './login-component.vue';

export default {
  components:{LoginComponent},
  name:'HeaderComponent',

  data(){
    return{
      userName:'',
      isLoggedIn:false,
    }
  },

  methods:{
    childDataRecived(userName, isLoggedIn){
      this.userName = userName;
      this.isLoggedIn = isLoggedIn;
    },
    print(){
      console.log(this.userName + ' ' + this.isLoggedIn)
    },
    logOut(){
      this.$store.state.isLoggedIn = false;
      this.$store.state.userName = '';
      this.$router.replace('/')
    }
  },

}
</script>

<style>
</style>