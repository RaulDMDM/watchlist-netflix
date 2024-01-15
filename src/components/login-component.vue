<template>
    <div>
        <form @submit.prevent="checkUser">
            <input type="text" v-model="userName" class=" form-text mx-2" placeholder="Usuario">
            <input type="password" v-model="userPass" class=" form-text mx-2" placeholder="Contraseña">
            <button @click="checkUser" class="btn btn-light mx-2">Acceder</button>
        </form>
    </div>
</template>

<script>
    import axios from "axios";
    export default {

        name:'LoginComponent',

        data(){
            return{
            userName: '',
            userPass: '',
            isLoggedIn: false
            }
        },
        methods:{

            checkUser(){
                axios.get("https://localhost:7286/api/User/GetUserByName/" + this.userName).then(response => {
                        if(response.data.userPassword == this.userPass){
                            this.$router.push("global");
                            this.isLoggedIn = true;
                            this.$store.state.userName = this.userName;
                            this.$store.state.isLoggedIn = this.isLoggedIn;
                        }else{
                            alert('Contraseña incorrecta')
                        }
                    }).catch((error)=>{
                        console.log(error);
                        alert('Usuario no valido')
                })
            },

            clearForm(){
                this.userName = '';
                this.userPass = '';
            }
        }
        
    }
</script>

<style>

</style>