<template>
  <HeaderNav />
  <div class="bg-gray-100 min-h-screen flex">

    <div class="w-1/3 bg-white shadow-md overflow-y-auto">
      <h2 class="text-lg font-bold text-green-600 p-4 border-b">Conversations</h2>
      <ul>
        <li
          v-for="(conversation, index) in conversations"
          :key="index"
          @click="selectConversation(index)"
          class="p-4 cursor-pointer border-b hover:bg-green-50 transition"
          :class="{ 'bg-green-100': selectedConversationIndex === index }"
        >
          <p class="font-semibold text-gray-800">{{ conversation.sender }}</p>
          <p class="text-sm text-gray-600 truncate">{{ conversation.messages[0].text }}</p>
        </li>
      </ul>
    </div>


    <div class="flex-1 bg-gray-50 flex flex-col">
      <div v-if="selectedConversation" class="flex-1 overflow-y-auto p-6">
        <h2 class="text-lg font-bold text-green-600 mb-4">
          Chat with {{ selectedConversation.sender }}
        </h2>
        <div v-for="(message, index) in selectedConversation.messages" :key="index" class="mb-4 text-black">
          <p
            class="p-3 rounded-md shadow text-sm max-w-xs"
            :class="{
              'bg-green-200  self-end': message.sentByUser,
              'bg-gray-200  self-start': !message.sentByUser
            }"
          >
            {{ message.text }}
          </p>
        </div>
      </div>
      <div v-else class="flex-1 flex items-center justify-center text-gray-500">
        Select a conversation to view messages
      </div>


      <div class="p-4 border-t bg-white sticky" >
        <form @submit.prevent="sendMessage" class="flex">
          <input
            v-model="newMessage"
            type="text"
            placeholder="Type a message..."
            class="flex-1 p-2 border rounded-l-md focus:outline-none focus:ring focus:ring-green-200"
          />
          <button
            type="submit"
            class="bg-green-600 text-white px-4 rounded-r-md hover:bg-green-700 transition"
          >
            Send
          </button>
        </form>
      </div>
    </div>
  </div>
</template>

<script>
import HeaderNav from './HeaderNav.vue';
export default {
  data() {
    return {
      conversations: [
        {
          sender: "Héger Gábor",
          messages: [
            { text: "Fantasztikus lett ez a projekt, kár, hogy nem működik rendesen!", sentByUser: false },
            { text: "gg", sentByUser: true },
          ],
        },
        {
          sender: "Tóth Attila",
          messages: [
            { text: "Várjatok, ez a kód most valamiért nem működik, átmegyek a másik csoport anyagára, ott megoldottuk már ezt a részt.", sentByUser: false },
            { text: "Oksa", sentByUser: true },
          ],
        },
        {
          sender: "Árgilán Viktor",
          messages: [
            { text: "Sem nem", sentByUser: false },
          ],
        },
      ],
      selectedConversationIndex: null,
      newMessage: "",
    };
  },
  computed: {
    selectedConversation() {
      return this.selectedConversationIndex !== null
        ? this.conversations[this.selectedConversationIndex]
        : null;
    },
  },
  methods: {
    selectConversation(index) {
      this.selectedConversationIndex = index;
    },
    sendMessage() {
      if (this.newMessage.trim() && this.selectedConversation) {
        this.selectedConversation.messages.push({
          text: this.newMessage.trim(),
          sentByUser: true,
        });
        this.newMessage = "";

        this.scrollToBottom();
      }
    },
    scrollToBottom() {
      this.$nextTick(() => {
        const chatContainer = document.querySelector(".flex-1.overflow-y-auto");
        if (chatContainer) {
          chatContainer.scrollTop = chatContainer.scrollHeight;
        }
      });
    },
  },
  components: {
    HeaderNav
  },
};
</script>