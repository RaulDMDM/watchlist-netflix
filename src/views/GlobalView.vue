<template>
    <div id="filters" class="navbar-dark bg-dark d-flex flex-row justify-content-center p-2">
        <i class="bi bi-search" style="color: white"></i>
        <input type="text" v-model="searchQuery" @keyup="filterByName" class="mx-4">
    </div>
    <div>
        <div id="myLists" class="bg-gradient bg-black bg-opacity-75 text-light">
            <h1 class="text-center text-light bg-gradient bg-black p-2">Mis listas de reproducción</h1>
        </div>
        <div id="movies" class="bg-gradient bg-black bg-opacity-75">
            <h1 class="text-center text-light bg-gradient bg-black p-2">Películas</h1>
            <ul class="d-flex flex-column list-unstyled align-items-center">
                <template v-for="content in filteredContent" :key="content.contentId">
                    <table v-if="content.type == 'Pelicula'" class="w-50 text-light">
                        <tr>
                            <td rowspan="4" class="w-25"><img :src="content.imageUrl" :alt="content.contentName" class="imageDisplay img-thumbnail"></td>
                            <td class="h2">{{ content.contentName }}</td>
                            <td rowspan="4" class="w-25 text-center"><button class="btn btn-light">Añadir a lista</button></td>
                        </tr>
                        <tr>
                            <td> {{ content.director }}</td>
                        </tr>
                        <tr>
                            <td>{{ content.genre }}</td>
                        </tr>
                        <tr>
                            <td>{{ content.contentDescription }}</td>
                        </tr>
                    </table>          
                </template>
            </ul>
        </div>
        <div id="tvShows" class="bg-gradient bg-black bg-opacity-75">
            <h1 class="text-center text-light bg-gradient bg-black p-2">Series</h1>
            <ul class="d-flex flex-column list-unstyled align-items-center">
                <template v-for="content in filteredContent" :key="content.contentId">
                    <table v-if="content.type == 'Serie'" class="w-50 text-light">
                        <tr>
                            <td rowspan="4" class="w-25"><img :src="content.imageUrl" :alt="content.contentName" class="imageDisplay img-thumbnail"></td>
                            <td class="h2">{{ content.contentName }}</td>
                            <td rowspan="4" class="w-25 text-center"><button class="btn btn-light">Añadir a lista</button></td>
                        </tr>
                        <tr>
                            <td> {{ content.director }}</td>
                        </tr>
                        <tr>
                            <td>{{ content.genre }}</td>
                        </tr>
                        <tr>
                            <td>{{ content.contentDescription }}</td>
                        </tr>
                    </table>          
                </template>
            </ul>
        </div>
    </div>
</template>

<script>
    import axios from "axios";
    export default {
        name: 'GlobalComponent',
        data(){
            return{
                contentList: [],
                filteredContent: [],
                searchQuery: '',
            }
        },

        methods:{
            printContent(){
                try {
                    axios.get('https://localhost:7286/api/Content').then(response =>{
                        this.contentList = response.data;
                        this.filteredContent = this.contentList;
                    })
                } catch (error) {
                    console.log(error)
                }
            },
            filterByName(){
                if (this.searchQuery){
                    this.filteredContent = this.contentList.filter( film => {return film.contentName.toLowerCase().includes(this.searchQuery.toLowerCase())})
                }
                else{
                    console.log(this.searchQuery);
                    this.filteredContent = this.contentList;
                }
            }
        },

        created: function(){
            this.printContent();
        }


    }
</script>

<style>

    .imageDisplay{
        width: 200px;
    }

    ul{
        margin: 0px!important;
        padding: 10px;
    }
    table{
        box-shadow: 0px 0px 6px rgb(173, 173, 173);
        border-radius: 2%;
        background-color:rgb(54, 54, 54);
        margin-top: 10px;
    }

</style>