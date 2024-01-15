<template>
  <header-component></header-component>
  <router-view/>
</template>

<script>
import HeaderComponent from './components/header-component.vue';

export default {
  components:{HeaderComponent},
  created:function(){
    if(this.$store.state.isLoggedIn == false){
      this.$router.replace('/')
    }
  }

}
</script>

<style>
  body{
    background-color: rgb(0, 0, 0);
    background-image: url('./assets/Background.webp');
    background-attachment: fixed;
    background-size: cover;
  }
</style>
