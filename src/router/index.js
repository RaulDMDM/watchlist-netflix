import { createRouter, createWebHashHistory } from 'vue-router'
import WelcomeView from '../views/WelcomeView.vue'
import GlobalView from '../views/GlobalView.vue'

const routes = [
  {
    path: '/',
    name: 'welcome',
    component: WelcomeView
  },
  {
    path: '/global',
    name: 'global',
    component: GlobalView
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
